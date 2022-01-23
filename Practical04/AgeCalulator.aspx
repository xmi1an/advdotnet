<%--4. Write a program to calculate the age from selected date using calculator.--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AgeCalulator.aspx.cs" Inherits="AgeCalulator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
    <tr>
        <td>
            <asp:DropDownList ID="ddlYears" runat="server" Width="100">
            </asp:DropDownList>
        </td>
        <td>
            <asp:DropDownList ID="ddlMonths" runat="server" Width="100">
                <asp:ListItem Text="January" Value="1" />
                <asp:ListItem Text="February" Value="2" />
                <asp:ListItem Text="March" Value="3" />
                <asp:ListItem Text="April" Value="4" />
                <asp:ListItem Text="May" Value="5" />
                <asp:ListItem Text="June" Value="6" />
                <asp:ListItem Text="July" Value="7" />
                <asp:ListItem Text="August" Value="8" />
                <asp:ListItem Text="September" Value="9" />
                <asp:ListItem Text="October" Value="10" />
                <asp:ListItem Text="November" Value="11" />
                <asp:ListItem Text="December" Value="12" />
            </asp:DropDownList>
        </td>
        <td>
            <asp:DropDownList ID="ddlDates" runat="server" Width="100">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td colspan="3" align="center">
            <asp:Button Text="Calculate" runat="server" OnClick="CalculateAge" />
        </td>
    </tr>
    <tr>
        <td>
            You are :
        </td>
        <td colspan="3" align="center">
            <asp:TextBox runat="server" ID="txtAge" Width="220" />
        </td>
    </tr>
</table>
        </div>
    </form>
</body>
</html>
