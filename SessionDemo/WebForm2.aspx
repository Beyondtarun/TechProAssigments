<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="PracticeC_.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    body{
    display : flex;
    justify-content: center;
    align-content: center;
     }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> <asp:Label ID="Label1" runat ="server"></asp:Label></h1><br />
            <asp:Button ID="Logout" runat="server" OnClick ="LOGOUT"  Text="LOGOUT"/>

        </div>
    </form>
</body>
</html>
