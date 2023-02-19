<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="loginandregister.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome...<asp:Label ID="Label1" runat="server"></asp:Label>
            </h1><br /> <br /> <br />
            <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />


        </div>
    </form>
</body>
</html>
