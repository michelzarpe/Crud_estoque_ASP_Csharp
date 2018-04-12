using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categoria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void buttonNovo_Click(object sender, EventArgs e)
    {
        limparFormulario();
    }

    protected void buttonCadastrar_Click(object sender, EventArgs e)
    {

    }

    protected void buttonDeletar_Click(object sender, EventArgs e)
    {

    }

    protected void buttonPesquisar_Click(object sender, EventArgs e)
    {

    }

    private void carregarGrid()
    {

    }

    private void inserirPoduto()
    {

        limparFormulario();
    }

    private void alterarPoduto()
    {

        limparFormulario();
    }

    private void deletarPoduto()
    {

        limparFormulario();
    }

    private void limparFormulario()
    {
        textID.Text = String.Empty;
        textNome.Text = String.Empty;
    }

}