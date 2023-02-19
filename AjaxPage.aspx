<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxPage.aspx.cs" Inherits="loginandregister.AjaxPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>WORKING WITH AJAX</h1>
        <p>
            <asp:ScriptManager ID="ScriptManager1"
                runat="server">
            </asp:ScriptManager>
        </p>
        
        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" Text="Data Here"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel2"
            runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server"
                    Interval="6000" OnTick="Timer1_Tick">
                </asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>

    </form>
</body>
</html>
