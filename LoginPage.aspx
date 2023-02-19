<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="loginandregister.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        
    <title></title>
    <style>
        .div{
            display: flex;
            justify-content: center;
            text-align: center;
        }
    </style>
</head>
<body>
    <div class="div">
    <form id="form1" runat="server">
        <div>
            <h1 class="text-3xl font-bold underline">Login
                </h1>
         
                <asp:Label ID="Label1" runat="server" Text="username"></asp:Label>
         
                <asp:TextBox ID="TextBox1" runat="server" Width="211px"></asp:TextBox>
      
          
                <br />
            <asp:Label ID="Label2" CssClass="font-bold" runat="server" Text="password"></asp:Label>
      
          
                <asp:TextBox ID="TextBox2" runat="server" Width="210px" TextMode="Password"></asp:TextBox>
            
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
            
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/RegisterPage.aspx">Register</asp:HyperLink>
            
        </div>
    </form>
        </div>
</body>
</html>
