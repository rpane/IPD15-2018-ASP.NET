﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="BlackJack.Game" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <div id="dealer">
            <div class="Cards">
                <asp:Image ID="Image1" runat="server" Height="249px" Width="168px" />
                <asp:Image ID="Image2" runat="server" Height="249px" Width="168px" />
            </div>
        </div>

        <div id="player">
            <div class="Cards">
                <asp:Image ID="Image3" runat="server" Height="249px" Width="168px" />
                <asp:Image ID="Image4" runat="server" Height="249px" Width="168px" />
            </div>
        </div>
    </form>
</body>
</html>
