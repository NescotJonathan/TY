<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="AramarkFinal.UserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This order is for:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            I am a:<br />
            <asp:RadioButton ID="rbStudent" runat="server" Text="Student" />
&nbsp;<asp:RadioButton ID="rbFaculty" runat="server" Text="Faculty Member" />
            <br />
            <br />
            My phone number is:
            <asp:TextBox ID="txtPhone" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnOk" runat="server" Text="Complete Order" OnClick="btnOk_Click" />
        </div>
    </form>
</body>
</html>
