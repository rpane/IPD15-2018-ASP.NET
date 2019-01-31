<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Class2Example1.Default"%>

<%@ Register Src="~/UserInfoBoxControl.ascx" TagPrefix="uc1" TagName="UserInfoBoxControl" %>


<%
    this.HelloWorldLabel.Text = "This is from the script block";
%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:UserInfoBoxControl runat="server" ID="UserInfoBoxControl" UserName="Aziz" UserAge="28" UserCountry="Iran"/>
            <br /><br />
            <asp:Label ID="HelloWorldLabel" runat="server"></asp:Label>
            <br /><br />
            <asp:TextBox ID="TextInput" runat="server"></asp:TextBox>

            <asp:Button ID="GreetButton" runat="server" Text="Say Hello!" OnClick="GreetButton_Click" />
            <br /><br />
            <asp:DropDownList ID="GreetList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="GreetList_SelectedIndexChanged">
                <asp:ListItem Value="no one">No one</asp:ListItem>
                <asp:ListItem Value="world">World</asp:ListItem>
                <asp:ListItem Value="universe">Universe</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
