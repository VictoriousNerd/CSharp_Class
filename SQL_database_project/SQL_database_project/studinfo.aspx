<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studinfo.aspx.cs" Inherits="SQL_database_project.studinfo" %>

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
                        <asp:Label ID="stuRollNum_Label" runat="server" Text="Student Roll Number"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="stuRollNum_Text" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="stuName_Label" runat="server" Text="Student Name"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="stuName_Text" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="stuCourseName_Label" runat="server" Text="Student Course Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="stuCourseName_Text" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                   <td>
                       <asp:Label ID="stuContNum_Label" runat="server" Text="Student Contact Number"></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="stuContNum_Text" runat="server"></asp:TextBox>
                   </td>
                </tr>
                <tr>
                   <td>
                       <asp:Label ID="stuEmail_Label" runat="server" Text="Student Email Address"></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="stuEmail_Text" runat="server"></asp:TextBox>
                   </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <p>
                            <asp:Button ID="displayUser" runat="server" Text="Display User" OnClick="displayUser_Click" />
                        </p>
                        <p>
                            <asp:Button ID="submitUser" runat="server" Text="Submit User" OnClick="submitUser_Click" />
                        </p>
                        <p>
                            <asp:Button ID="updateUser" runat="server" Text="Update User" OnClick="updateUser_Click" />
                        </p>
                        <p>
                            <asp:Button ID="deleteUser" runat="server" Text="Delete User" OnClick="deleteUser_Click" />
                        </p>                 
                        <p>
                            <asp:GridView ID="stuInfo_View" runat="server"></asp:GridView>
                        </p>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
