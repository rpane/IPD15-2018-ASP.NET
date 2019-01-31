<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Class4.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="helloWorldLabel" runat="server"></asp:Label><br>
            <asp:TextBox ID="textBox" runat="server"></asp:TextBox><br>
            <asp:Button ID="greetButton" runat="server" Text="Button" OnClick="greetButton_Click" />
            <br />
            <asp:DropDownList ID="greetList" AutoPostBack="true" runat="server" OnSelectedIndexChanged="greetList_SelectedIndexChanged">
                <asp:ListItem Selected="True" Value="no one">No one</asp:ListItem>
                <asp:ListItem Value="world">World</asp:ListItem>
                <asp:ListItem Value="univers">Universe</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
