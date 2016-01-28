<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmployeeClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Write the ID of the Employee you want to read or edit:
        <asp:TextBox ID="tbxGetEmpId" runat="server"></asp:TextBox>
        <asp:Button ID="btnGetEmployee" runat="server" OnClick="btnGetEmployee_Click" Text="Get Employee" />
        <br />
        <br />
        Employee ID:
        <asp:TextBox ID="tbxEmployeeID" runat="server" Enabled="False"></asp:TextBox>
    
    </div>
        <p>
            Firstname:
            <asp:TextBox ID="tbxFirstName" runat="server" Width="552px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbxFirstName" ErrorMessage="The given Firstname is not in a valid format (a-ö A-Ö). Change it to a valid format before proceeding" ValidationExpression="[a-z åäö \- A-Z ÅÄÖ]+"></asp:RegularExpressionValidator>
        </p>
        <p>
            Lastname:<asp:TextBox ID="tbxLastName" runat="server" Width="565px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tbxLastName" ErrorMessage="The given Lastname is not in a valid format (a-ö A-Ö). Change it to a valid format before proceeding." ValidationExpression="[a-z åäö\- A-Z ÅÄÖ]+"></asp:RegularExpressionValidator>
        </p>
        <p>
            Address:
            <asp:TextBox ID="tbxAddress" runat="server" Width="577px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="tbxAddress" ErrorMessage="The given Address is not in a valid format (a-ö A-Ö  and digits). Change it to a valid format before proceeding." ValidationExpression="[a-z åäö \- \. A-Z ÅÄÖ \d]+"></asp:RegularExpressionValidator>
        </p>
        <p>
            Postal Code: <asp:TextBox ID="tbxPostalCode" runat="server" Width="561px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator13" runat="server" ControlToValidate="tbxPostalCode" ErrorMessage="The given Postal code is not in a valid format (A-Ö and digits). Change it to a valid format before proceeding." ValidationExpression="[A-Z ÅÄÖ \d]+"></asp:RegularExpressionValidator>
        </p>
        <p>
            City:<asp:TextBox ID="tbxCity" runat="server" Width="607px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="tbxCity" ErrorMessage="The given City is not in a valid format (a-ö A-Ö ). Change it to a valid format before proceeding." ValidationExpression="[a-z åäö \- A-Z ÅÄÖ]+"></asp:RegularExpressionValidator>
        </p>
        <p>
            Region:<asp:TextBox ID="tbxRegion" runat="server" Width="598px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="tbxRegion" ErrorMessage="The given Region is not in a valid format (a-ö A-Ö). Change it to a valid format before proceeding." ValidationExpression="[a-z åäö \- A-Z ÅÄÖ]+"></asp:RegularExpressionValidator>
        </p>
        <p>
            Country:<asp:TextBox ID="tbxCountry" runat="server" Width="598px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="tbxCountry" ErrorMessage="The given Country is not in a valid format (a-ö A-Ö ). Change it to a valid format before proceeding." ValidationExpression="[a-z åäö  \- A-Z ÅÄÖ]+"></asp:RegularExpressionValidator>
        </p>
        <p>
            Birthdate:<asp:TextBox ID="tbxBirthDate" runat="server" Width="599px"></asp:TextBox>
            <asp:Label ID="lblBirthDateError" runat="server"></asp:Label>
        </p>
        <p>
            Hiredate:<asp:TextBox ID="tbxHireDate" runat="server" Width="605px"></asp:TextBox>
            <asp:Label ID="lblHireDateError" runat="server"></asp:Label>
        </p>
        <p>
            Notes:<asp:TextBox ID="tbxNotes" runat="server" Width="620px"></asp:TextBox>
            <asp:Label ID="lblNotesError" runat="server"></asp:Label>
        </p>
        <p>
            Title:
            <asp:TextBox ID="tbxTitle" runat="server" Width="626px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="tbxTitle" ErrorMessage="The given Title is not in a valid format (a-ö A-Ö ). Change it to a valid format before proceeding." ValidationExpression="[a-z åäö \- \, A-Z ÅÄÖ]+"></asp:RegularExpressionValidator>
        </p>
        <p>
            Title of Courtesy: <asp:TextBox ID="tbxTitleOfCourtesy" runat="server" Width="626px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="tbxTitleOfCourtesy" ErrorMessage="The given Title of Courtesy is not in a valid format (a-z . A-Z) Change it to a valid format before proceeding." ValidationExpression="[a-z \. A-Z]+"></asp:RegularExpressionValidator>
        </p>
        <p>
            Home phone:
            <asp:TextBox ID="tbxHomePhone" runat="server" Width="626px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="tbxHomePhone" ErrorMessage="The given Phone number is not in a valid format (digits only ). Change it to a valid format before proceeding." ValidationExpression="[\d \-]+"></asp:RegularExpressionValidator>
        </p>
        <p>
            Extension
            <asp:TextBox ID="tbxExtension" runat="server" Width="626px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ControlToValidate="tbxExtension" ErrorMessage="The given Extension is not in a valid format (digits only). Change it to a valid format before proceeding." ValidationExpression="[\d]+"></asp:RegularExpressionValidator>
        </p>
        <p>
            Reports To:
            <asp:TextBox ID="tbxReportsTo" runat="server" Width="626px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator12" runat="server" ControlToValidate="tbxReportsTo" ErrorMessage="The given Reports is not in a valid format (digits only ). Change it to a valid format before proceeding." ValidationExpression="[\d]+"></asp:RegularExpressionValidator>
        </p>
        <p>
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save Changes" />
            <asp:Label ID="lblInfoText" runat="server" ForeColor="Blue"></asp:Label>
        </p>
    </form>
</body>
</html>
