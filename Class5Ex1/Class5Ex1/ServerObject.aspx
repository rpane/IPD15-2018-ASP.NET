﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerObject.aspx.cs" Inherits="Class5Ex1.SessionObject" %>

<!DOCTYPE html>

<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(TextBox1.Text))
        {
            // Access the HttpServerUtility methods through
            // the intrinsic Server object.
            Label1.Text = "Welcome, " +
                Server.HtmlEncode(TextBox1.Text) +
                ".<br/> The url is " +
                Server.UrlEncode(Request.Url.ToString())+"<br> The machine name is: "+Server.MachineName;
        }
    }

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HttpServerUtility Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter your name:<br />

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
            <asp:Label ID="Label1" runat="server" />
        </div>
    </form>
</body>
</html>

