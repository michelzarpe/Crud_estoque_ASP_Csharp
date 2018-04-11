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
            <asp:Button ID="buttonNovo" runat="server" Text="Novo" />
&nbsp;
            <asp:Button ID="buttonCadastrar" runat="server" Text="Cadastrar" />
&nbsp;
            <asp:Button ID="buttonDeletar" runat="server" Text="Deletar" />
&nbsp;
            <asp:Button ID="buttonPesquisar" runat="server" Text="Pesquisar" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox ID="textID" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Nome: "></asp:Label>
            <asp:TextBox ID="textNome" runat="server" Width="327px"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Descrição:"></asp:Label>
            <asp:TextBox ID="textDescricao" runat="server" Height="158px" TextMode="MultiLine" Width="301px"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Valor de Custo:"></asp:Label>
            <asp:TextBox ID="textPreco_Custo" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Valor de Venda:"></asp:Label>
            <asp:TextBox ID="textPreco_Venda" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Quantidade:"></asp:Label>
            <asp:TextBox ID="textQuantidade" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Unidade Medida:"></asp:Label>
            <asp:TextBox ID="textUnidadeMedida" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Categoria:"></asp:Label>
            <asp:DropDownList ID="dropDownListCategoria" runat="server">
            </asp:DropDownList>
            <br />
            <asp:GridView ID="gridViewProdutos" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Width="705px">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
