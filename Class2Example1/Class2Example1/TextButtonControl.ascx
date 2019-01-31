<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TextButtonControl.ascx.cs" Inherits="Class2Example1.TextButtonControl" %>

Page title:
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="TextBox1" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter a value"></asp:RequiredFieldValidator>
<br /><br />
<asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click"/>