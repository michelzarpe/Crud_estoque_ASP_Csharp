<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Categoria.aspx.cs" Inherits="Categoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Names="Arial Black" ForeColor="Black" Text="Cadastro de Estoques"></asp:Label>
            <br />
            <asp:Button ID="buttonNovo" runat="server" Text="Novo" Width="90px" OnClick="buttonNovo_Click" />
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
        </div>
    </form>
</body>
</html>
