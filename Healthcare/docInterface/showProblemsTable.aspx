<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="showProblemsTable.aspx.cs" Inherits="Healthcare.docInterface.WebForm3" %>

<%@ Import Namespace="System.Data" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
   <script type="text/JavaScript" src="../Scripts/jquery-1.4.1-vsdoc.js"></script>  
   <script type="text/JavaScript" src="../Scripts/jquery-1.4.1.js"></script>  
   <script type="text/JavaScript" src="../Scripts/jquery-1.4.1.min.js"></script>  
   
  <script type="text/JavaScript">
      $(document).ready(function () {
          $("#generate").click(function () {
              $("#quote p").load("problemDetails.aspx?nameauto=Shoubhik");
          });
      });  
  </script> 
  
    <style type="text/css">     
        
        .style1
        {
            width: 76px;
            text-align: center;
        }
        .style2
        {
            text-align: center;
            width: 84px;
        }
        .style3
        {
            font-size: x-large;
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

<input type="button" id="generate" value="Ajax button" /><br />
    <br />
    &nbsp;<div id="quote">  <p></p>
    </div>


    
<div>
    <p align="center"">

        &nbsp;<span class="style3">Table of health records</span></p>

    </div>

&nbsp;<div id="table_list">
        <table 
            style="width:87%; font-size: medium;" align='center'>

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
