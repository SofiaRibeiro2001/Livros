<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editar2.aspx.cs" Inherits="Ex4.Edita2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Edição de Cliente</h1>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="lbl_id" runat="server" Text="Id:"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_id" runat="server" Columns="3" ReadOnly="true"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lbl_nome" runat="server" Text="Nome:"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_nome" runat="server" Columns="50"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lbl_npag" runat="server" Text="Nº Pág:"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_npag" runat="server" Columns="5"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lbl_tam" runat="server" Text="Tamanho:"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_tam" runat="server" Columns="10"></asp:TextBox>
            <br /><br />
            <asp:Button ID="b_alterar" runat="server" Text="Alterar" OnClick="b_alterar_Click"></asp:Button>&nbsp;
            <asp:Button ID="b_cancelar" runat="server" Text="Cancelar" OnClick="b_cancelar_Click" ></asp:Button>
        </div>
    </form>
</body>
</html>
