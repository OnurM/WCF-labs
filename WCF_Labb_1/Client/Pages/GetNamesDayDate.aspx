﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetNamesDayDate.aspx.cs" Inherits="Client.Pages.GetNamesDayDate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get date!" />
&nbsp;&nbsp;&nbsp; =&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="???"></asp:Label>
    
    </div>
    </form>
</body>
</html>