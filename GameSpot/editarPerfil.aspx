<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editarPerfil.aspx.cs" Inherits="GameSpot.editarPerfil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Regresar" />
            <br />
            <br />
            Editar Perfil<br />
            <br />
            Correo&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="236px"></asp:TextBox>
            <br />
            <br />
            Nombre&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="224px"></asp:TextBox>
            <br />
            <br />
            Sexo&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Edad&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="80px"></asp:TextBox>
            <br />
            <br />
            Contraseña nueva&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
            <br />
            <br />
            Repita la nueva contraseña&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" Width="181px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Acutualizar" />
            <br />
            <br />
            <br />
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
