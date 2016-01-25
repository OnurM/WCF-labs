<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShipperClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Shipper Code<br />
        <asp:TextBox ID="tbxShipperCode" runat="server" Width="440px"></asp:TextBox>
        <br />
        <asp:Button ID="btnGetShipper" runat="server" OnClick="btnGetShipper_Click" style="height: 26px" Text="Get Shipper" />
        <br />
        <br />
        <br />
        EDIT SHIPPER DATA<br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        Shipper id<br />
        <asp:TextBox ID="tbxShipperId" runat="server" Enabled="False" Width="440px"></asp:TextBox>
        <br />
        Company name<br />
        <asp:TextBox ID="tbxCompanyName" runat="server" Width="440px"></asp:TextBox>
        <br />
        Phone<br />
        <asp:TextBox ID="tbxPhone" runat="server" Width="440px"></asp:TextBox>
        <br />
        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
    
    </div>
    </form>
</body>
</html>
