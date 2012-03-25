<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="showProblemsTable.aspx.cs" Inherits="Healthcare.docInterface.WebForm3" %>

<%@ Import Namespace="System.Data" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
   
    <style type="text/css">     
        
        .style1
        {
            width: 76px;
            text-align: center;
        }
        .style2
        {
            text-align: center;
            width: 270px;
        }
        .style3
        {
            font-size: large;
        }
        #quote
        {
            height: 49px;
        }
        .style4
        {
            width: 217px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <p align="center"" class="style3">

            <strong>&nbsp;Table of health records</strong></p>

    </div>

&nbsp;<div id="table_list">
        <table 
            style="width:78%; font-size: medium;" align='center'>

            <thead>
            
             <tr>


             <td>ISSUE-ID</td><td>CARE-SEEKER NAME</td><td>MAIN PROBLEM</td><td>DISCUSSION</td>
            
            </tr>

            </thead>

        <%
            DataTable dt = getData();

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                String name = dt.Rows[i]["nameauto"].ToString();
                String patient_data_id = dt.Rows[i]["patient_data_id"].ToString();
                name = getProperString(name);
             %>
            <tr>

            <td class="style1" bgcolor="#FFFFCC" valign="top"> 
            
            

            <a href="problemDetails.aspx?patient_data_id=<%=patient_data_id%>"><%= dt.Rows[i]["patient_data_id"].ToString() %> </a>
            
             
            
            </td>

            <td class="style4">
            
              <a href="problemDetails.aspx?patient_data_id=<%=patient_data_id%>"><%= dt.Rows[i]["nameauto"].ToString() %> </a>
            
            </td>


            <td class="style2" bgcolor="#FFFFCC" valign="top">  <%= dt.Rows[i]["mainHealthIssue"].ToString()%> </td>

            <td>
            
            <a href="discussion.aspx?problem_id=<%=dt.Rows[i]["patient_data_id"]%>">DISCUSSION PAGE</a>

            </td>
            </tr>
            <%
            }
                 %>
        </table>
    </div>
</asp:Content>
