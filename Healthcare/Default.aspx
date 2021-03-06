﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Healthcare._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            font-size: large;
        }
        .style2
        {
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        &nbsp;</h2>
    <p class="style2">
        CARE-SEEKERS,<asp:HyperLink ID="HyperLink2" runat="server" 
            NavigateUrl="~/user/newUser.aspx">CREATE ANONYMOUS ACCOUNT AND SUBMIT HEALTH RECORD</asp:HyperLink>
    </p>
    <p class="style2">
        CARE-GIVERS, 
        <asp:HyperLink ID="HyperLink1" runat="server" 
            NavigateUrl="~/docInterface/createNewDoc.aspx">REGISTER HERE</asp:HyperLink>
    </p>
    <p>
        Download the
        <asp:HyperLink ID="HyperLink3" runat="server" 
            NavigateUrl="https://docs.google.com/open?id=1lE-DaWEML5WliIg_Eo_T2VawP0ztZ5uCrXGvf8hAjb5o75QNg0tkmikWLLsH">UHDC Patient consent form </asp:HyperLink>
    </p>
    <p>
        &nbsp;</p>
    </asp:Content>
