<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Thema Sept 2021 Web Form.aspx.cs" Inherits="Thema_Sept_2021.Thema_Sept_2021_Web_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="firstWordLabel" runat="server" Text="Give me the first word: "></asp:Label>
            <asp:TextBox ID="FirstWordTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="secondWordLabel" runat="server" Text="Give me the second word: "></asp:Label>
            <asp:TextBox ID="SecondWordTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="PlithosLabel" runat="server" Text="Give me plithos: "></asp:Label>
            <asp:TextBox ID="PlithosTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="OperationButton" runat="server" OnClick="OperationButton_Click" Text="Start operation" />
            <br />
            <br />
            <asp:Label ID="ResultLabel" runat="server" Text="Result: "></asp:Label>
            <asp:Label ID="ResultOfOperationLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
