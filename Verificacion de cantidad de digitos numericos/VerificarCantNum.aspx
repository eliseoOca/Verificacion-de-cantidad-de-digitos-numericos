<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerificarCantNum.aspx.cs" Inherits="Verificacion_de_cantidad_de_digitos_numericos.VerificarCantNum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtNumero" runat="server" placeholder="Ingrese un numero"></asp:TextBox>
            <asp:Button ID="btnVerificar" runat="server" Text="Verificar" OnClick="btnVerificar_Click" />
            <asp:Label ID="lblResultado" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
