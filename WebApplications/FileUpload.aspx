<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="WebApplications.FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <asp:Button ID="FileUploadBtn" runat="server" Text="Button" OnClick="FileUploadBtn_Click" />
            <br />
        </div>
        <asp:Label ID="lblMessage" runat="server" Font-Bold="true"></asp:Label>
    </form>
</body>
</html>
