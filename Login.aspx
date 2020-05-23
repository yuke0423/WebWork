<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录界面</title>
</head>
<body>
    <form id="form1" runat="server">
        <table border="1" id="tb" align="center" >
        <tr>
        <td>用户名：</td>
        <td><asp:TextBox ID="txtUser" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>密&nbsp;&nbsp码</td>
            <td><asp:TextBox ID="txtPwd" runat="server"  TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
        <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" />
            </td>
 
            </tr>
        </table>

    </form>
</body>
</html>
