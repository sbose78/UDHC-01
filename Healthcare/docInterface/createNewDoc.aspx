<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="createNewDoc.aspx.cs" Inherits="Healthcare.docInterface.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            font-size: large;
        }
        .style3
        {
            color: #000099;
        }
        .style2
        {
            font-size: x-large;
        }
        .style4
        {
            font-size: large;
        }
        .style5
        {
            font-size: large;
            color: #000099;
        }
        .style6
        {
            color: #000000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p class="style6">
        <br />
        <span class="style1">CARE - GIVER REGISTRATION</span></p>
    <p>
        <span class="style4">Choose a user-id:
        </span>
        <asp:TextBox ID="TextBox1CareGiverID" runat="server" Width="244px" 
            CssClass="style4"></asp:TextBox>
    </p>
    <p>
        <span class="style4">Upload a photo of yours&nbsp; 
        </span> 
        <asp:FileUpload ID="FileUpload1User_pic" runat="server" Width="218px" 
            CssClass="style4" />
    </p>
    <p class="style5">
        Upload Credentials to prove you can be a care-giver (a voter id for self labeled 
        social workers and an institutional document/degree for medical students and 
        health professionals)</p>
    <p>
        <span class="style4">&nbsp;</span><asp:FileUpload ID="FileUpload2" 
            runat="server" CssClass="style4" />
    </p>
    <p>
        <span class="style4">Email address:
        </span>
        <asp:TextBox ID="TextBoxEmailId" runat="server" Width="236px" CssClass="style4"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="COMPLETE REGISTRATION" Width="223px" />
    </p>
    <p>
        <span class="style2">YOUR DEFAULT PASSWORD WILL BE:</span><span class="style3"><span 
            class="style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <strong>12345</strong></span></span></p>
    <p>
    </p>
</asp:Content>
