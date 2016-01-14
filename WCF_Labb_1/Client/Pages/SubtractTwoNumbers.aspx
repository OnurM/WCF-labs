<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubtractTwoNumbers.aspx.cs" Inherits="Client.Pages.SubtractTwoNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="tbxA" runat="server"></asp:TextBox>
&nbsp; -&nbsp;
        <asp:TextBox ID="tbxB" runat="server"></asp:TextBox>
&nbsp; =&nbsp;
        <asp:Label ID="lblSubtractResult" runat="server" Text="?"></asp:Label>
&nbsp;&nbsp;
        <asp:Button ID="btnSubtract" runat="server" OnClick="btnSubtract_Click" Text="Calculate!" />
    
    </div>
    </form>
</body>
</html>
