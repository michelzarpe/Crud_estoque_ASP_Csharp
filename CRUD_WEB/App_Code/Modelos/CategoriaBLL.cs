using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

public class CategoriaBLL
{
    public DataAccessLayer dal = new DataAccessLayer();
    private int id { get; set; }
    private string nome { get; set; }

    public CategoriaBLL()
    {
        
    }


    public DataTable retornaCategoria()
    {
        MySqlCommand comando = new MySqlCommand();
        comando.CommandText = "select * from categoria";
        return dal.retDataTable(comando);
        
    }


    public DataTable retornaCategoriaEspecifica(int id)
    {
        MySqlCommand comando = new MySqlCommand();
        comando.CommandText = "select * from categoria where id = @id";
        comando.Parameters.AddWithValue("@id", id);
        return dal.retDataTable(comando);
    }

    public void inserirCategoria()
    {
        string sql = "INSERT INTO categoria (nome) " +
            "VALUES (@nome)";
        MySqlCommand comando = new MySqlCommand();
        comando.Parameters.AddWithValue("@nome", nome);
        comando.CommandText = sql;
        dal.executarComando(comando);
    }


    public void alterarCategoria()
    {
        MySqlCommand comando = new MySqlCommand();
        string sql = "UPDATE categoria SET NOME=@nome WHERE ID = @id";
        comando.Parameters.AddWithValue("@id", id);
        comando.Parameters.AddWithValue("@nome", nome);
        comando.CommandText = sql;
        dal.executarComando(comando);
    }

    public void deletarCategoria()
    {
        MySqlCommand comando = new MySqlCommand();
        string sql = "DELETE FROM categoria WHERE ID = @id";
        comando.Parameters.AddWithValue("@id", id);
        comando.CommandText = sql;
        dal.executarComando(comando);
    }

}