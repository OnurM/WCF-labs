<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTwoNumbers.aspx.cs" Inherits="Client.Pages.AddTwoNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="tbxFirstNumber" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;+
        <asp:TextBox ID="tbxSecondNumber" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;=
        <asp:Label ID="lblAddTwoNumbersResult" runat="server" Text="?"></asp:Label>
&nbsp;
        <asp:Button ID="btnAddTwoNumbers" runat="server" Text="Calculate!" />
    
    </div>
    </form>
</body>
</html>
