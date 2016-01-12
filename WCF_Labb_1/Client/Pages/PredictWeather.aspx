<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PredictWeather.aspx.cs" Inherits="Client.Pages.PredictWeather" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="lblWeather" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="btnPredictWeather" runat="server" OnClick="btnPredictWeather_Click" Text="Predict weather" />
        <br />
    
    </div>
    </form>
</body>
</html>
