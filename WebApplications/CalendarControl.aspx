<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalendarControl.aspx.cs" Inherits="WebApplications.CalendarControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Toggle Calendar" OnClick="Button1_Click" />
            <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>

        </div>
    </form>
</body>
</html>
