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
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <span class="style1">CARE - GIVER REGISTRATION</span></p>
    <p>
        Choose a user-id:
        <asp:TextBox ID="TextBox1CareGiverID" runat="server" Width="244px"></asp:TextBox>
    </p>
    <p>
        Upload a photo of yours&nbsp; 
        <asp:FileUpload ID="FileUpload1User_pic" runat="server" Width="218px" />
    </p>
    <p>
        Upload Credentials to prove you can be a care-giver:
        <asp:FileUpload ID="FileUpload2" runat="server" />
    </p>
    <p>
        Email address:
        <asp:TextBox ID="TextBoxEmailId" runat="server" Width="236px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="COMPLETE REGISTRATION" Width="223px" />
    </p>
    <p>
        <span class="style1">YOUR DEFAULT PASSWORD WILL BE:</span><span class="style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <span class="style2"><strong>12345</strong></span></span></p>
    <p>
    </p>
</asp:Content>
