<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="HiddenField1" runat="server" Value="0" />
                        <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click me" />
                        <br />
        </div>
    </form>
</body>
</html>
