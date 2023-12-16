<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropdownDataBind.aspx.cs" Inherits="WebApplications.dropdownDataBind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
