<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBoxList.aspx.cs" Inherits="WebApplications.CheckBoxList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="SelectAll" runat="server" Text="Select All" OnClick="SelectAll_Click" />
            <asp:Button ID="DeselectAll" runat="server" Text="Deselect All" OnClick="DeSelectAll_Click" />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="2" RepeatDirection="Horizontal" >
                <asp:ListItem Text ="Diploma" Value="1"></asp:ListItem>
                <asp:ListItem Text ="Graduate" Value="2"></asp:ListItem>
                <asp:ListItem Text ="Post Graduate" Value="3"></asp:ListItem>
                <asp:ListItem Text ="Doctrate" Value="4"></asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <br />
        
        <div> 
            <asp:Button Font-Bold="true" ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
