<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AramarkFinal.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Price: £3.60<br />
            Quantity:
            <asp:Label ID="lblCheeseQuantity" runat="server" Text="0"></asp:Label>
            x<br />
            <asp:Button ID="btnAddCheese" runat="server" Text="Add Cheese Pizza" />
            <br />
            <asp:Button ID="btnRemoveCheese" runat="server" Text="Remove Cheese Pizza" />
            <br />
            <br />
            Price: £3.80<br />
            Quantity:
            <asp:Label ID="lblPepperoniQuantity" runat="server" Text="0"></asp:Label>
            x<br />
            <asp:Button ID="btnAddPepperoni" runat="server" Text="Add Pepperoni Pizza" />
            <br />
            <asp:Button ID="btnRemovePepperoni" runat="server" Text="Remove Pepperoni Pizza" />
            <br />
            <br />
            Your total comes to:
            <asp:Label ID="lblTotal" runat="server" Text="£0.00"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnOk" runat="server" Text="Add to Order" />
        </div>
    </form>
</body>
</html>
