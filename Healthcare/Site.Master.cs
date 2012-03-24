using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Healthcare
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Label1.Text = "You are logged in as " + Session["username"].ToString();
                Button1.Visible = false;
                Button2.Visible = true;

                
            }
            else
            {
                Label1.Text = "NOT LOGGED IN ";
                Button1.Visible = true;
                Button2.Visible = false;
                
                
            }
           

        }

        protected void LoginStatus1_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Account/Login.aspx");

           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Response.Redirect("../Account/Login.aspx");
        }

    }
       
}
 