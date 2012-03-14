<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="Healthcare.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        About
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="okay, upload now" />
    </h2>
    <p>
        Put content here.
        <asp:TextBox ID="TextBox1" runat="server" Height="144px" Width="396px"></asp:TextBox>
    </p>
</asp:Content>
