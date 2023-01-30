<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Thema Feb 2022 Web Form.aspx.cs" Inherits="Thema_Feb_2022.Thema_Feb_2022_Web_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="mainWord" runat="server" Text="Give me the main Word: "></asp:Label>
            <asp:TextBox ID="MainWordTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="wordForReplaceLabel" runat="server" Text="Give me the word you want to replace: "></asp:Label>
            <asp:TextBox ID="WordForReplaceTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="ReplacementWordLabel" runat="server" Text="Give me the replacement word:  "></asp:Label>
            <asp:TextBox ID="ReplacementWordTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ReplaceButton" runat="server" OnClick="ReplaceButton_Click" Text="Start Replacement" />
            <br />
            <br />
            <asp:Label ID="InitialWordLabel" runat="server" Text="Initial word: "></asp:Label>
            <asp:Label ID="InitialWordPlace" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="NewWordLabel" runat="server" Text="New word: "></asp:Label>
            <asp:Label ID="ResultWordLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
