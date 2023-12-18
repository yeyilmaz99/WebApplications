<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="WebApplications.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox Width="200" Height="300" ID="ListBox1" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        </div>

        <div>
            <table>
                <tr>
                    <td>Company Name:</td>
                    <td>
                        <asp:TextBox ID="CompanyName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Contact Name:</td>
                    <td>
                        <asp:TextBox ID="ContactName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Contact Title:</td>
                    <td>
                        <asp:TextBox ID="ContactTitle" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>City:</td>
                    <td>
                        <asp:TextBox ID="City" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>PostalCode:</td>
                    <td>
                        <asp:TextBox ID="PostalCode" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="DeleteButton" runat="server" Text="DELETE" BackColor="RED" OnClick="DeleteButton_Click" />
            <asp:Button ID="UpdateButton" runat="server" Text="UPDATE" BackColor="Yellow" OnClick="UpdateButton_Click" />

        </div>
    </form>
</body>
</html>
