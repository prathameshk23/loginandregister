<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="loginandregister.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            width: 580px;
        }
        .auto-style3 {
            width: 338px;
        }
        .auto-style4 {
            text-align: right;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            background-color: #6699FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table style="width:100%;" class="auto-style6">
          <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style1">Welcome 
                <asp:Label ID="Label8" runat="server"></asp:Label>
              </td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style1">Add details</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox1" runat="server" Width="400px"></asp:TextBox>
            </td>
        </tr>
                <tr>
            <td class="auto-style4">
                <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox2" runat="server" Width="400px"></asp:TextBox>
            </td>
        </tr>
                <tr>
            <td class="auto-style4">
                <asp:Label ID="Label3" runat="server" Text="Mobile No."></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox3" runat="server" Width="400px"></asp:TextBox>
            </td>
        </tr>
                <tr>
            <td class="auto-style4">
                <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox4" runat="server" Width="400px"></asp:TextBox>
            </td>
        </tr>
                <tr>
            <td class="auto-style4">
                <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox5" runat="server" Width="400px"></asp:TextBox>
            </td>
        </tr>
                <tr>
            <td class="auto-style4">
                <asp:Label ID="Label6" runat="server" Text="Aproval"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:RadioButton ID="yes" runat="server" Text="Yes" GroupName="app" />
&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" Text="No" GroupName="app" />
            </td>
        </tr>
                <tr>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="Label7" runat="server"></asp:Label>
                    </td>
        </tr>
                <tr>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="Button2" runat="server" Text="Logout" OnClick="Button2_Click"  />
            </td>
        </tr>
         <tr>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/UpdatePage.aspx">Update</asp:HyperLink>
            </td>
        </tr>
        </table>
    </form>
</body>
</html>
