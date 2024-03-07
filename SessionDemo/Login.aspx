<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PracticeC_.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #Label1{
            color: red;
        }
        body{
            display : flex;
            height : 97vh;
            width: 98vw;
            justify-content: center;
            align-items: center;
            color: white;
            background-color: #254446;
        }
        h1 , h2{
            color:black;
        }
        .Container{
          height: 250px;
          width: 350px;
          padding:20px;
          border-radius: 5%;
          text-align:center;
          background-color: cornflowerblue;
        }
        #Textbox2{
            margin-top: 5px;
            margin-left: 8px;
        }
        #LoginBtn{
            margin-top: 10px;
            border-radius: 8px;
            padding: 5px;
            
            color: aqua;
            background-color: black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Container"><center><h1>Session Demo C#</h1>
            <h2>Login Page</h2></center>
            
                UserName : <asp:TextBox ID="Textbox1" runat="server" placeholder="username" AutoComplete="off"></asp:TextBox><br />
                Password : <asp:TextBox ID="Textbox2" runat="server" TextMode="Password"  ></asp:TextBox><br />
                <asp:Button ID="LoginBtn" OnClick ="LOGIN" runat="server" Text="LOGIN"/>
                <br />
                
            
           <center><h1> <asp:Label ID="Label1" runat="server"></asp:Label></h1></center> 
        </div>
    </form>
</body>
</html>
