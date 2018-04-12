<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Produto.aspx.cs" Inherits="Produto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial, Helvetica, sans-serif; background-color: #3366FF; border: thin double #000000">
            <asp:Label ID="Label1" runat="server" Font-Names="Arial Black" ForeColor="Black" Text="Cadastro de Estoques"></asp:Label>
            <br />
            <asp:Button ID="buttonNovo" runat="server" Text="Novo" Width="90px" OnClick="buttonNovo_Click1" />
&nbsp;
            <asp:Button ID="buttonCadastrar" runat="server" Text="Cadastrar" Width="90px" OnClick="buttonCadastrar_Click" />
&nbsp;
            <asp:Button ID="buttonDeletar" runat="server" Text="Deletar" Width="90px" OnClick="buttonDeletar_Click" />
&nbsp;
            <asp:Button ID="buttonPesquisar" runat="server" Text="Pesquisar" Width="90px" OnClick="buttonPesquisar_Click" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="ID:" Width="150px"></asp:Label>
            <asp:TextBox ID="textID" runat="server" Width="300px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Nome: " Width="150px"></asp:Label>
            <asp:TextBox ID="textNome" runat="server" Width="300px"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Descrição:" Width="150px"></asp:Label>
            <asp:TextBox ID="textDescricao" runat="server" Height="158px" TextMode="MultiLine" Width="300px"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Valor de Custo:" Width="150px"></asp:Label>
            <asp:TextBox ID="textPreco_Custo" runat="server" Width="140px"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Valor de Venda:" Width="150px"></asp:Label>
            <asp:TextBox ID="textPreco_Venda" runat="server" Width="140px"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Quantidade:" Width="150px"></asp:Label>
            <asp:TextBox ID="textQuantidade" runat="server" Width="140px"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Unidade Medida:" Width="150px"></asp:Label>
            <asp:TextBox ID="textUnidadeMedida" runat="server" Width="140px"></asp:TextBox>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Categoria:" Width="150px"></asp:Label>
            <asp:DropDownList ID="dropDownListCategoria" runat="server" Width="140px" ValidateRequestMode="Disabled">
            </asp:DropDownList>
            <br />
            <asp:GridView ID="gridViewProdutos" runat="server" Height="114px" Width="522px">
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
