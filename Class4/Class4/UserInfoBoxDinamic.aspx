<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfoBoxDinamic.aspx.cs" Inherits="Class4.UserInfoBoxDinamic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:<asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            <br />
            Age:<asp:TextBox ID="tbAge" runat="server"></asp:TextBox>
            <br />
            City:<asp:TextBox ID="tbCity" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
            <br />
            <br />
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
