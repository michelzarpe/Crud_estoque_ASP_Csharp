using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Produto : System.Web.UI.Page
{
    public ProdutoBusinessLogicL produtoBLL = new ProdutoBusinessLogicL();
    public CategoriaBLL categoriaBLL = new CategoriaBLL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) { 
            this.carregandoCategorias();
            this.carregarGrid();
        }
    }
    
    private void carregandoCategorias()
    {
        dropDownListCategoria.DataSource = categoriaBLL.retornaCategoria();
        dropDownListCategoria.DataValueField = "id";
        dropDownListCategoria.DataTextField = "nome";
        dropDownListCategoria.DataBind();
    }

    private void carregarGrid()
    {
        gridViewProdutos.DataSource = produtoBLL.retornaProdutos();
        gridViewProdutos.DataBind();

    }

    private void inserirPoduto()
    {
        produtoBLL.nome = textNome.Text;
        produtoBLL.descricao = textDescricao.Text;
        produtoBLL.preco_custo = Decimal.Parse(textPreco_Custo.Text);
        produtoBLL.preco_venda = Decimal.Parse(textPreco_Venda.Text);
        produtoBLL.quantidade = Double.Parse(textQuantidade.Text);
        produtoBLL.unidade_medida = textUnidadeMedida.Text;
        produtoBLL.categoria_id = int.Parse(dropDownListCategoria.SelectedValue.ToString());
     
        produtoBLL.inserirProduto();
        
    }

    private void alterarPoduto()
    {
        produtoBLL.id = int.Parse(textID.Text);
        produtoBLL.nome = textNome.Text;
        produtoBLL.descricao = textDescricao.Text;
        produtoBLL.preco_custo = Decimal.Parse(textPreco_Custo.Text);
        produtoBLL.preco_venda = Decimal.Parse(textPreco_Venda.Text);
        produtoBLL.quantidade = Double.Parse(textQuantidade.Text);
        produtoBLL.unidade_medida = textUnidadeMedida.Text;
        produtoBLL.categoria_id = int.Parse(dropDownListCategoria.SelectedValue.ToString());
        produtoBLL.alterarProduto();
    }

    private void deletarPoduto()
    {
        produtoBLL.id = int.Parse(textID.Text);
        produtoBLL.deletarProduto();
    }

    private void limparFormulario()
    {
        textID.Text = String.Empty;
        textNome.Text = String.Empty;
        textDescricao.Text = String.Empty;
        textPreco_Custo.Text = String.Empty;
        textPreco_Venda.Text = String.Empty;
        textQuantidade.Text = String.Empty;
        textUnidadeMedida.Text = String.Empty;
    }

    private void carregarProdutoIdentificado() {
        DataTable dt = produtoBLL.retornaProdutoEspecifico(int.Parse(textID.Text));
        textNome.Text = dt.Rows[0]["nome"].ToString();
        textDescricao.Text = dt.Rows[0]["descricao"].ToString();
        textPreco_Custo.Text = dt.Rows[0]["preco_custo"].ToString();
        textPreco_Venda.Text = dt.Rows[0]["preco_venda"].ToString();
        textQuantidade.Text = dt.Rows[0]["quantidade"].ToString();
        textUnidadeMedida.Text = dt.Rows[0]["unidade_medida"].ToString();
        dropDownListCategoria.SelectedValue = dt.Rows[0]["categoria_id"].ToString();

    }
    
    /*acao dos botoes*/
    protected void buttonNovo_Click1(object sender, EventArgs e)
    {
        this.limparFormulario();
    }

    protected void buttonCadastrar_Click(object sender, EventArgs e)
    {
        
        if (String.IsNullOrEmpty(this.textID.Text))
        {
            this.inserirPoduto();
            this.limparFormulario();
            this.carregarGrid();

        }
        else
        {
            this.alterarPoduto();
            this.limparFormulario();
            this.carregarGrid();
          
        }
        
    }

    protected void buttonDeletar_Click(object sender, EventArgs e)
    {
        this.deletarPoduto();
        this.limparFormulario();
        this.carregarGrid();
    }

    protected void buttonPesquisar_Click(object sender, EventArgs e)
    {
        this.carregarProdutoIdentificado();
    }

   
}