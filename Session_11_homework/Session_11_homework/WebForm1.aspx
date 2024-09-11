<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Session_11_homework.WebForm1" %>

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
                    <td>
                        Assignment 1:<br />
                        <asp:Label ID="countResult" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>     
                        Assignment 2:<br />
                        <asp:Label ID="posNumResult" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Assignment 3:<br />
                        <asp:Label ID="cityListResults" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Assignment 4:<br />
                        <asp:Label ID="arraySquaredResult" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Assignment 5<br />
                        <asp:ListBox ID="lstMovies" runat="server" Width="200px" Height="150px"></asp:ListBox>
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
