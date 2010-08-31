<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

 

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <b><asp:Label ID="lblfecha" runat="server" Text="Ingresa tu Fecha de Nacimiento:"></asp:Label></b><br /><br />
        <asp:Label ID="lbldia" runat="server" Text="Día:"></asp:Label>
        <asp:TextBox ID="txtdia" runat="server"></asp:TextBox>
        <asp:Label ID="lblmes" runat="server" Text="Mes:"></asp:Label>
        <asp:TextBox ID="txtmes" runat="server"></asp:TextBox>
        <asp:Label ID="lblanio" runat="server" Text="Año:"></asp:Label>
        <asp:TextBox ID="txtanio" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="Button1" runat="server" Text="Calcular" 
            onclick="Button1_Click" /><br />
        <asp:Label ID="lblresult" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
