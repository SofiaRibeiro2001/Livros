<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="Ex4.Eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Eliminar Dados</h1>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="lbl_id" runat="server" Text="Id:"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_id" runat="server" Columns="10" ReadOnly="True"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lbl_nome" runat="server" Text="Nome:"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_nome" runat="server" Columns="50" ReadOnly="true"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lbl_npag" runat="server" text="Nª Pág.:"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_npag" runat="server" columns="5" readonly="true"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lbl_tam" runat="server" text="Tamanho:"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_tam" runat="server" columns="10" readonly="true"></asp:TextBox>
            <br /><br />
            <asp:Button ID="b_eliminar" runat="server" Text="Eliminar" onClick="b_eliminar_Click" />
            <asp:Button ID="b_cancelar" runat="server" Text="Cancelar" />
        </div>
    </form>
</body>
</html>
