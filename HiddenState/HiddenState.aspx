<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenState.aspx.cs" Inherits="PracticeC_.HiddenState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hidden State in C#</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hiddentext" runat="server" />
            <h1><asp:Label ID="Label1" runat="server"></asp:Label></h1>
            
        </div>
    </form>
</body>
</html>
