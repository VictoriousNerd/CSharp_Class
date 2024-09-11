<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="account_info.aspx.cs" Inherits="database_with_linq.account_info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td>Account Number:</td>
                    <td>
                        <asp:TextBox ID="accNum" runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Account Holder Name:</td>
                    <td>
                        <asp:TextBox ID="accName" runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Account Type:</td>
                    <td>
                        <asp:TextBox ID="accType" runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Account Balance:</td>
                    <td>
                      <asp:TextBox ID="accBal" runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="Button1" runat="server" Text="Button" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="Button2" runat="server" Text="Button" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="Button3" runat="server" Text="Button" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="Button4" runat="server" Text="Button" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="Button5" runat="server" Text="Button" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
