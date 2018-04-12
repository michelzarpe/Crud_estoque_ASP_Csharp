using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

public class ProdutoBusinessLogicL
{
    public int id { get; set; }
    public string nome { get; set; }
    public string descricao { get; set; }
    public Decimal preco_custo { get; set; }
    public Decimal preco_venda { get; set; }
    public double quantidade { get; set; }
    public string unidade_medida { get; set; }
    public int categoria_id { get; set; }
    public DataAccessLayer dal = new DataAccessLayer();

    public ProdutoBusinessLogicL()
    {
        

    }
    
    public DataTable retornaProdutos()
    {
        MySqlCommand comando = new MySqlCommand();
        comando.CommandText = "select p.id as Codigo, p.nome as Nome, p.descricao as Descricao, p.preco_custo as Vlr_custo," +
            " p.preco_venda as Vlr_Venda, p.quantidade as Quantidade, " +
            "p.unidade_medida as Unidade_Medida, c.nome as Categoria " +
            "from produto p " +
            "left join categoria c on p.categoria_id = c.id";
        return dal.retDataTable(comando);
    }


    public DataTable retornaProdutoEspecifico(int id)
    {
        MySqlCommand comando = new MySqlCommand();
        comando.CommandText = "select * from produto where id = @id";
        comando.Parameters.AddWithValue("@id", id);
        return dal.retDataTable(comando);
    }

    public void inserirProduto()
    {
        string sql = "INSERT INTO produto (nome,descricao,preco_custo,preco_venda,quantidade,unidade_medida,categoria_id) " +
            "VALUES (@nome,@descricao,@preco_custo,@preco_venda,@quantidade,@unidade_medida,@categoria_id)";
        MySqlCommand comando = new MySqlCommand();
        comando.Parameters.AddWithValue("@descricao", descricao);
        comando.Parameters.AddWithValue("@preco_custo", preco_custo);
        comando.Parameters.AddWithValue("@nome", nome);
        comando.Parameters.AddWithValue("@preco_venda", preco_venda);
        comando.Parameters.AddWithValue("@quantidade", quantidade);
        comando.Parameters.AddWithValue("@unidade_medida", unidade_medida);
        comando.Parameters.AddWithValue("@categoria_id", categoria_id);
        comando.CommandText = sql;
        dal.executarComando(comando);
    }


    public void alterarProduto()
    {
        MySqlCommand comando = new MySqlCommand();
        string sql = "UPDATE produto SET NOME=@nome, DESCRICAO=@descricao, PRECO_CUSTO=@preco_custo, PRECO_VENDA=@preco_venda, QUANTIDADE=@quantidade," +
            " UNIDADE_MEDIDA=@unidade_medida, CATEGORIA_ID=@categoria_id WHERE ID = @id";
        comando.Parameters.AddWithValue("@id", id);
        comando.Parameters.AddWithValue("@descricao", descricao);
        comando.Parameters.AddWithValue("@preco_custo", preco_custo);
        comando.Parameters.AddWithValue("@nome", nome);
        comando.Parameters.AddWithValue("@preco_venda", preco_venda);
        comando.Parameters.AddWithValue("@quantidade", quantidade);
        comando.Parameters.AddWithValue("@unidade_medida", unidade_medida);
        comando.Parameters.AddWithValue("@categoria_id", categoria_id);
        comando.CommandText = sql;
        dal.executarComando(comando);
    }

    public void deletarProduto()
    {
        MySqlCommand comando = new MySqlCommand();
        string sql = "DELETE FROM PRODUTO WHERE ID = @id";
        comando.Parameters.AddWithValue("@id", id);
        comando.CommandText = sql;
        dal.executarComando(comando);
    }

}