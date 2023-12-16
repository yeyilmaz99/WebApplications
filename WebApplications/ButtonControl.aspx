<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonControl.aspx.cs" Inherits="WebApplications.ButtonControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="PrintButton" runat="server" Text="Print" OnCommand="Buttons_Command" CommandName="Print"/>
            <asp:Button ID="DeleteButton" runat="server" Text="Delete" OnCommand="Buttons_Command" CommandName="Delete" />
            <asp:Button ID="Top10Button" runat="server" Text="Show 10" OnCommand="Buttons_Command" CommandName="Show" CommandArgument="Top10" />
            <asp:Button ID="Bottom10Button" runat="server" Text="Show Bottom 10" OnCommand="Buttons_Command" CommandName="Show" CommandArgument="Bottom10" />

            <asp:Label ID ="OutputLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
