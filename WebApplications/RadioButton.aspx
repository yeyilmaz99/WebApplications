<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButton.aspx.cs" Inherits="WebApplications.RadioButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset style="width:150px">
                <asp:RadioButton GroupName="gender" ID="MaleRadio" runat="server" Text="Male" OnCheckedChanged="MaleRadio_CheckedChanged" /> <br />
                <asp:RadioButton GroupName="gender" ID="FemaleRadio" runat="server" Text="Female" /> <br />
                <asp:RadioButton GroupName="gender" ID="UnknownRadio" runat="server" Text="Unknown" /> <br 
            </fieldset>

            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
