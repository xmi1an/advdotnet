<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style13 {
            width: 31%;
            height: 186px;
        }
        .auto-style18 {
            width: 6px;
        }
        .auto-style20 {
            width: 6px;
            height: 36px;
        }
        .auto-style21 {
            width: 66px;
            height: 36px;
        }
        .auto-style22 {
            height: 36px;
            width: 11px;
        }
        .auto-style23 {
            width: 11px;
        }
        .auto-style24 {
            width: 66px;
        }
        .auto-style25 {
            width: 31%;
        }
        .auto-style26 {
            width: 124px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtanswer" runat="server" Height="41px" Width="227px"></asp:TextBox>
        </div>
        <table cellpadding="3" cellspacing="4" class="auto-style13">
            <tr>
                <td class="auto-style22">
                    <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" BackColor="#66FF99" ForeColor="Black" Width="50px" />
                </td>
                <td class="auto-style20">
                    <asp:Button ID="btnZero" runat="server" Text="0" Width="50px" />
                </td>
                <td class="auto-style21">
                    <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" Width="55px" BackColor="#FF6262" ForeColor="White" />
                </td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:Button ID="btnOne" runat="server" Text="1" OnClick="btnOne_Click" Width="50px" />
                </td>
                <td class="auto-style20">
                    <asp:Button ID="btnTwo" runat="server" Text="2" OnClick="btnTwo_Click" Width="50px" />
                </td>
                <td class="auto-style21">
                    <asp:Button ID="btnThree" runat="server" Text="3" OnClick="btnThree_Click" Width="50px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style23">
                    <asp:Button ID="btnFour" runat="server" Text="4" OnClick="btnFour_Click" Width="50px" />
                </td>
                <td class="auto-style18">
                    <asp:Button ID="btnFive" runat="server" Text="5" OnClick="btnFive_Click" Width="50px" />
                </td>
                <td class="auto-style24">
                    <asp:Button ID="btnSix" runat="server" Text="6" OnClick="btnSix_Click" Width="50px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style23">
                    <asp:Button ID="btnSeven" runat="server" Text="7" OnClick="btnSeven_Click" Width="50px" />
                </td>
                <td class="auto-style18">
                    <asp:Button ID="btnEight" runat="server" Text="8" OnClick="btnEight_Click" Width="50px" />
                </td>
                <td class="auto-style24">
                    <asp:Button ID="btnNine" runat="server" Text="9" OnClick="btnNine_Click" Width="50px" />
                </td>
            </tr>
        </table>
        <table class="auto-style25">
            <tr>
                <td>
                    <asp:Button ID="Add" runat="server" Text="+" OnClick="Add_Click" Font-Bold="True" Height="50px" Width="50px" />
                </td>
                <td>
                    <asp:Button ID="Sub" runat="server" Text="-" OnClick="Sub_Click" Font-Bold="True" Height="50px" Width="50px" />
                </td>
                <td>
                    <asp:Button ID="Multiply" runat="server" Text="*" OnClick="Multiply_Click" Font-Bold="True" Height="50px" Width="50px" />
                </td>
                <td class="auto-style26">
                    <asp:Button ID="Divide" runat="server" Text="/" Font-Bold="True" Height="50px" Width="50px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>