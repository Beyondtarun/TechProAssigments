<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ViewState_Demo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tarun Goyal</title>
    <link rel="stylesheet" href="FileName.css" text="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>View State Demo</h1>
             <table>
                <tr>
                    <td>UserName:</td>
                    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Restore" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
