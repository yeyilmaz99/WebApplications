<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplications.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--TextMode, Text, MaxLength, ToolTip, Columns, AutoPostBack, OnTextChanged,--%>
            <asp:TextBox ID="TextBox1" runat="server" Text="this is the text" ReadOnly="true"></asp:TextBox>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
            
    </form> 
</body>
</html>
