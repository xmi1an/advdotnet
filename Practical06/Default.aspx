<%--6. Write a program to demonstrate Login Page using Database.--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 132px;
        }
        .auto-style2 {
            width: 131px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <table cellpadding="4" class="auto-style1">
                <tr>
                    <td class="auto-style1">Username</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtUsername" runat="server" Height="16px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Password</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        </div>
    </form>
</body>
</html>
