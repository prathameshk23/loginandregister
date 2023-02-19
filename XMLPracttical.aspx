<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XMLPracttical.aspx.cs" Inherits="loginandregister.XMLPracttical" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Writing in XML File</h1>
        <p>First Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>Last Name: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>Mobile Number: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server"></asp:Label><br /><br />
        <asp:Button ID="Button1" runat="server" Text="Write XML" OnClick="Button1_Click" /><br /><br />
        <h1>Reading from XML File</h1>
        <p>First Name:
        <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
        <p>Last Name:
        <asp:Label ID="Label3" runat="server"></asp:Label>
        </p>
        <p>Mobile Number:
        <asp:Label ID="Label4" runat="server"></asp:Label></p>
        <asp:Label ID="Label5" runat="server"></asp:Label>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Read XML" OnClick="Button2_Click" />

    </form>
</body>
</html>
