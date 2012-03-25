<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="discussion.aspx.cs" Inherits="Healthcare.docInterface.WebForm5" %>

<%@ Import Namespace="System.Data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            font-size: x-large;
        }
        .style2
        {
            width: 870px;
        }
        .style3
        {
            width: 85px;
        }
        .style4
        {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <span class="style4">Network processing : Care-givers for patient &nbsp;</span></p>
    <p>
        PROBLEM ID :&nbsp;
        <asp:TextBox ID="TextBox2ProblemId" runat="server" Height="22px" Width="142px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server">SEE THE HEALTH RECORD..</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PATIENT NAME:



        <asp:TextBox ID="TextBox3PatientName" runat="server" Height="19px" 
            Width="127px"></asp:TextBox>
            </p>
    
        <asp:TextBox ID="TextBox1Suggestion" runat="server" Height="72px" 
            Width="830px" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
       <asp:Button ID="Button1" runat="server" Height="24px" onclick="Button1_Click" 
        style="margin-top: 0px" Text="Submit suggestion" Width="262px" />
    <br />
    <br />
    <br />
    <table style="border-style: solid">
    <%
        DataTable dt = getData();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
         %>
    <tr><td style="border-width: thin; border-style: groove;" class="style3"><%=dt.Rows[i]["doc_id"]%> said,</td>
        <td style="border-width: thin; border-style: groove;" class="style2"><%=dt.Rows[i]["comment"]%></td></tr>
    <%} %>

    </table>
    </asp:Content>
