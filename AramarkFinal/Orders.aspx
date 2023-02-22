<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="AramarkFinal.Orders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnGoToPizzas" runat="server" OnClick="btnGoToPizzas_Click" Text="Pizzas" />
            <asp:Button ID="btnGoToOrders" runat="server" BackColor="Gray" Enabled="False" Text="Orders" />
            <asp:Button ID="btnGoToStaffPanel" runat="server" OnClick="btnGoToStaffPanel_Click" Text="Staff Panel" />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    <asp:BoundField DataField="Cheese" HeaderText="Cheese" SortExpression="Cheese" />
                    <asp:BoundField DataField="Pepperoni" HeaderText="Pepperoni" SortExpression="Pepperoni" />
                    <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                    <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Id], [Name], [Price], [Cheese], [Pepperoni], [Status], [Time] FROM [Order]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
