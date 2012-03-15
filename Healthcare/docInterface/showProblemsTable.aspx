<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="showProblemsTable.aspx.cs" Inherits="Healthcare.docInterface.WebForm3" %>

<%@ Import Namespace="System.Data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 254px;
            text-align: center;
        }
        .style2
        {
            text-align: center;
        }
        .style3
        {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p align="center"">

        &nbsp;<span class="style3">Table of health records</span><table style="width:58%;" align='center'>

        <%
            DataTable dt = getData();

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                String name = dt.Rows[i]["nameauto"].ToString();
                name = getProperString(name);
             %>
            <tr>

            <td class="style1"> 
            
            

            <a href="problemDetails.aspx?nameauto=<%=name%>"><%= dt.Rows[i]["nameauto"].ToString() %> </a>
            
             
            
            </td>
            <td class="style2">  <%= dt.Rows[i]["mainHealthIssue"].ToString()%> </td>

            </tr>
            <%
            }
                 %>
        </table>
    </p>
</asp:Content>
