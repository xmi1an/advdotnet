<%--17. Write a program for pass one web form value to another web form using session variable.--%>
<%@ Page Trace="true" Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">  
    <table class="auto-style1">  
        <tr>  
            <td class="auto-style2">Username</td>  
            <td>  
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td class="auto-style2">Password</td>  
            <td>  
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td class="auto-style2"> </td>  
            <td>  
                <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click" />  
            </td>  
        </tr>  
    </table>  
    <br />  
    <asp:Label ID="Label3" runat="server"></asp:Label>  
    <br />  
    <asp:Label ID="Label4" runat="server"></asp:Label>  
</form>   
</body>
</html>
