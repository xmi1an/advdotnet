<%--10. Write a program which use the AJAX Timer Control.--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TimerControl.aspx.cs" Inherits="TimerControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <br />
                    <asp:Timer ID="Timer1" runat="server" Interval="500" OnTick="Timer1_Tick">
                    </asp:Timer>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
        </div>
    </form>
</body>
</html>
