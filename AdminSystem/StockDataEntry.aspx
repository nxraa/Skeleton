<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProductId" runat="server" style="z-index: 1; left: 12px; top: 50px; position: absolute" Text="Product ID"></asp:Label>
        <asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; left: 116px; top: 49px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 116px; top: 97px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblName" runat="server" height="22px" style="z-index: 1; left: 13px; top: 95px; position: absolute" Text="Name" width="86px"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" height="22px" style="z-index: 1; left: 12px; top: 143px; position: absolute" Text="Description" width="86px"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 13px; top: 189px; position: absolute; height: 22px; width: 56px" Text="Price"></asp:Label>
        <asp:Label ID="lblStockLevel" runat="server" style="z-index: 1; left: 12px; position: absolute; height: 43px; width: 63px; top: 233px" Text="Stock Level"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 13px; top: 287px; position: absolute; height: 46px; width: 86px" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 115px; top: 145px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 114px; top: 195px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStockLevel" runat="server" style="z-index: 1; left: 115px; top: 248px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 114px; top: 302px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkAvailableInStore" runat="server" style="z-index: 1; left: 12px; top: 350px; position: absolute" Text="Available In Store" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 396px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 13px; top: 442px; position: absolute" Text="Ok" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 63px; top: 441px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>
