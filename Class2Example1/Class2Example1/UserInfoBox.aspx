<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfoBox.aspx.cs" Inherits="Class2Example1.UserInfoBox" %>

<%@ Register Src="~/UserInfoBoxControl.ascx" TagPrefix="uc1" TagName="UserInfoBoxControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:UserInfoBoxControl runat="server" ID="UserInfoBoxControl1"/>
        </div>
    </form>
</body>
</html>
