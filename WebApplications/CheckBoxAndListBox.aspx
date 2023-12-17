<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBoxAndListBox.aspx.cs" Inherits="WebApplications.CheckBoxAndListBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="2" RepeatDirection="Horizontal" AutoPostBack="true" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
                <asp:ListItem Text ="Diploma" Value="1"></asp:ListItem>
                <asp:ListItem Text ="Graduate" Value="2"></asp:ListItem>
                <asp:ListItem Text ="Post Graduate" Value="3"></asp:ListItem>
                <asp:ListItem Text ="Doctrate" Value="4"></asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div>
            <asp:ListBox ID="ListBox1" runat="server" Width="200" Height="200" SelectionMode="Multiple"></asp:ListBox>
        </div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
