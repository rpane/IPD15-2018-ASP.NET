<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextButtonClient.aspx.cs" Inherits="Class4.TextButtonClient" %>

<%@ Register Src="~/TextButtonControl.ascx" TagPrefix="uc1" TagName="TextButtonControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:TextButtonControl runat="server" id="TextButtonControl" />
        </div>
    </form>
</body>
</html>
