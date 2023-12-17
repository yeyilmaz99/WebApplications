<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CascadingDropdown.aspx.cs" Inherits="WebApplications.CascadingDropdown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--autoPostBack olmazsa çalışmaz, Çünkü cached eventi autoPostBack e çevirmemiz gerekir--%>
            <asp:DropDownList ID="ddlCategories" Width="100px" runat="server" OnSelectedIndexChanged="ddlCategories_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            <br />
            <asp:DropDownList ID="ddlProducts" Width="100px" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
