<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nuevaCritica.aspx.cs" Inherits="GameSpot.nuevaCritica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="#CC0000" ForeColor="White" OnClick="Button1_Click" Text="Cerrar Sesión" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Regresar" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Selecciona el juago"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Título:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="409px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Calificación:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Contenido"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Height="222px" Width="961px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Enviar" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
