<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XMLPRac2.aspx.cs" Inherits="loginandregister.XMLPRac2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h1> Writing Xml into file</h1></div>
        <p>
            Enter your Full Name :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;Enter your Email :
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter your Contact No :<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Write XML" OnClick="Button1_Click" />
    <p>
        &nbsp;</p>
    <h1>Reading Xml from File</h1>
        <p>Full Name:<asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
        <p>Email: <asp:Label ID="Label3" runat="server"></asp:Label>
        </p>
        <p>Contact No :<asp:Label ID="Label4" runat="server"></asp:Label>
        </p>
        <p>&nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Read XML" />
        </p>
    </form>
    </body>
</html>
