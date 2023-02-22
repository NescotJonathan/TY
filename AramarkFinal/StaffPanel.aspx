<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffPanel.aspx.cs" Inherits="AramarkFinal.StaffPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            Password:
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Log In" />
            <br />
            <br />
            <asp:GridView ID="grdOrders" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" Visible="False">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    <asp:BoundField DataField="Cheese" HeaderText="Cheese" SortExpression="Cheese" />
                    <asp:BoundField DataField="Pepperoni" HeaderText="Pepperoni" SortExpression="Pepperoni" />
                    <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
                    <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                </Columns>
                <SelectedRowStyle BackColor="#CC99FF" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Order]"></asp:SqlDataSource>
            <br />
            <asp:Label ID="lblGridError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnConfirm" runat="server" Text="Confirm Order" Visible="False" OnClick="btnConfirm_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete Order" Visible="False" OnClick="btnDelete_Click" />
        </div>
    </form>
</body>
</html>
