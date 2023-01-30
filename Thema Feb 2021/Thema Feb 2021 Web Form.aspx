<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Thema Feb 2021 Web Form.aspx.cs" Inherits="Thema_Feb_2021.Thema_Feb_2021_Web_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">  
        <div>
            <asp:Label ID="ThirdPowerLabel0" runat="server" Text="Enter the number for the 1st operation: "></asp:Label>
            <asp:TextBox ID="ThirdPowerTextBox0" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ThirdPowerButton0" runat="server" OnClick="ThirdPowerButton_Click" Text="Calculate thirdPower" />


            <br />
            <br />
            <asp:Label ID="ResultLabel1" runat="server" Text="Result: "></asp:Label>
            <asp:Label ID="ResultOfFirstOperation" runat="server"></asp:Label>


            <br />
            <br />
            <asp:Label ID="baseNumberLabel0" runat="server" Text="Enter the number for the base: "></asp:Label>
            <asp:TextBox ID="baseNumberTextBox0" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="exponentNumberLabel0" runat="server" Text="Enter the number for the exponent: "></asp:Label>
            <asp:TextBox ID="exponentNumberTextBox0" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="powerOfTwoNumbersButton0" runat="server" Text="Calculate power of 2 numbers" OnClick="powerOfTwoNumbersButton0_Click" />
            <br />
            <br />
            <asp:Label ID="ResultLabel2" runat="server" Text="Result: "></asp:Label>
            <asp:Label ID="ResultOfSecondOperation" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
