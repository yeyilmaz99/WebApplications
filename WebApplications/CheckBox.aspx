<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBox.aspx.cs" Inherits="WebApplications.CheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Graduate" /> <br />
                <asp:CheckBox ID="CheckBox2" runat="server" Text ="Post Graduate" /> <br />
                <asp:CheckBox ID="CheckBox3" runat="server" Text ="Doctrate"/>
            </fieldset>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
