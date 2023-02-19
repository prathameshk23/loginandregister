<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CriPage.aspx.cs" Inherits="loginandregister.CriPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Add Match Details : </h1>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lblid" runat="server"
                        Text="Match ID : "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtid"
                        runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblscore" runat="server"
                        Text="Score : "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtscore"
                        runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblwick" runat="server"
                        Text="Wickets :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtwick"
                        runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblovers" runat="server"
                        Text="Overs :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtovers"
                        runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblextra" runat="server"
                        Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnaddmatch"
                        runat="server" Text="ADD MATCH"
                        OnClick="btnaddmatch_Click" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server"
            NavigateUrl="~/Ajax.aspx">ScorePage</asp:HyperLink>
    </form>
</body>
</html>
