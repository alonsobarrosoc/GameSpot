<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nuevaCritica.aspx.cs" Inherits="GameSpot.nuevaCritica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nueva Crítica</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Regresar" />
            <br />
            <br />
            <br />
            Genera una nueva crítica<br />
            <br />
            Consola&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Título&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server" Width="272px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Calificación&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            Contenido<br />
            <asp:TextBox ID="TextBox2" runat="server" Height="36px" Width="505px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Publicar" />
            <br />
        </div>
    </form>
</body>
</html>
