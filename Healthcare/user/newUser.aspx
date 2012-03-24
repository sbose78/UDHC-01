<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="newUser.aspx.cs" Inherits="Healthcare.user.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            font-size: medium;
            color: #000099;
        }
        .style2
        {
            font-size: large;
        }
        .style3
        {
            color: #000099;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p align="center">
        &nbsp;</p>
    <p align="center">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="CREATE A NEW 'CARE-SEEKER' ACCOUNT" />
    </p>
    <p align="center">
        <span class="style1">YOUR DEFAULT PASSWORD WILL BE:</span><span class="style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <span class="style2"><strong>12345</strong></span></span></p>
    <p align="center">
        &nbsp;</p>
</asp:Content>
