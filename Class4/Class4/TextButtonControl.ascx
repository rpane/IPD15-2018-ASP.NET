<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TextButtonControl.ascx.cs" Inherits="Class4.TextButtonControl" %>


<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" ControlToValidate="TextBox1" runat="server" ErrorMessage="Enter a value"></asp:RequiredFieldValidator>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
</p>

