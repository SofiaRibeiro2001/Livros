<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insere.aspx.cs" Inherits="Ex4.Insere" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_nome" runat="server" Text="Nome:"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_nome" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lbl_npag" runat="server" Text="Nº de paginas:"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_npag" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lbl_tam" runat="server" Text="Tamanho:"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_tam" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Inserir" OnClick="Button1_Click1" />
        </div>
    </form>
</body>
</html>
