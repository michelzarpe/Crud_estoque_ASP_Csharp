using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; //utilizado para trocar informação entre objeto mysql e frameWork
using MySql.Data.MySqlClient;

/// <summary>
/// Descrição resumida de DataAccessLayer
/// </summary>
public class DataAccessLayer
{
    private string servidor = "localhost";
    private string database = "estoque";
    private string user = "root";
    private string password = "";
    private string connectionString = "Server={0};Database={1};Uid={2};Pwd={3};";
    private MySqlConnection mySqlConnection;

    public DataAccessLayer()
    {
        connectionString = String.Format(connectionString,servidor,database,user,password);
        mySqlConnection = new MySqlConnection(connectionString);
        mySqlConnection.Open();
    }

    public DataTable retDataTable(string sql)
    {
        DataTable data = new DataTable();
        MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
        MySqlDataAdapter dat = new MySqlDataAdapter(mysqlCommand);
        dat.Fill(data);
        return data; 
    }

    public void executarComandoSql(string sql)
    {
        MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
        mysqlCommand.ExecuteNonQuery();
    }
}