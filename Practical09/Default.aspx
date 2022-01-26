<%--9. Write a program which use the AJAX UpdateProgress Control.--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 48px;
            height: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        
        <br /><br />
       
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Click Me" OnClick="Button1_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>
        
        <br />

        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
            <ProgressTemplate>
                <span> Loading.. </span>
            </ProgressTemplate>
        </asp:UpdateProgress>
    </form>
</body>
</html>
