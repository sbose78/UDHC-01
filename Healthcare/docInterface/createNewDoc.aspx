<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="createNewDoc.aspx.cs" Inherits="Healthcare.docInterface.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
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
        Care -GIVER ID:
        <asp:TextBox ID="TextBox1CareGiverID" runat="server" Width="244px"></asp:TextBox>
    </p>
    <p>
        Upload image:
        <asp:FileUpload ID="FileUpload1User_pic" runat="server" Width="218px" />
    </p>
    <p>
        Upload Credentials :
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
    </p>
</asp:Content>
