<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="discussion.aspx.cs" Inherits="Healthcare.docInterface.WebForm5" %>

<%@ Import Namespace="System.Data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <span class="style1">Network processing : Care-givers for patient: </span>&nbsp;</p>
    <p>
        PROBLEM ID :&nbsp;
        <asp:TextBox ID="TextBox2ProblemId" runat="server" Height="22px" Width="322px"></asp:TextBox>
&nbsp; PATIENT NAME:



        <asp:TextBox ID="TextBox3PatientName" runat="server" Height="19px" 
            Width="310px"></asp:TextBox>
            </p>
    
        <asp:TextBox ID="TextBox1Suggestion" runat="server" Height="72px" 
            Width="830px" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
       <asp:Button ID="Button1" runat="server" Height="39px" onclick="Button1_Click" 
        style="margin-top: 0px" Text="Submit suggestion" Width="262px" />
    <br />
    <br />
    <table style="border-style: solid">
    <%
        DataTable dt = getData();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
         %>
    <tr><td style="border-color: #C0C0C0; border-style: groove;"><%=dt.Rows[i]["doc_id"]%> said,</td>
        <td style="border-style: inset; font-size: medium; color: #000000; background-color: #FFFFCC;"><%=dt.Rows[i]["comment"]%></td></tr>
    <%} %>

    </table>
    </asp:Content>
