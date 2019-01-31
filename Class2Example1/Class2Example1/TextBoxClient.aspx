<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextBoxClient.aspx.cs" Inherits="Class2Example1.TextBoxClient" %>

<%@ Register Src="~/TextButtonControl.ascx" TagPrefix="uc1" TagName="TextButtonControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:TextButtonControl runat="server" id="TextButtonControl1" />
        </div>
    </form>
</body>
</html>
