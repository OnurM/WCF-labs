<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddThreeNumbers.aspx.cs" Inherits="Client.Pages.AddThreeNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="tbxA" runat="server"></asp:TextBox>
&nbsp;+
        <asp:TextBox ID="tbxB" runat="server"></asp:TextBox>
&nbsp;+
        <asp:TextBox ID="tbxC" runat="server"></asp:TextBox>
&nbsp;=&nbsp;
        <asp:Label ID="lblAddThreeNumbers" runat="server" Text="?"></asp:Label>
&nbsp;
        <asp:Button ID="btnAddThreeNumbers" runat="server" OnClick="btnAddThreeNumbers_Click" Text="Calculate!" />
    
    </div>
    </form>
</body>
</html>
