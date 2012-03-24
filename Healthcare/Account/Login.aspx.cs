using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Healthcare.user;

namespace Healthcare.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl ="../user/newUser.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);            
        }
        protected void login(object sender, EventArgs e)
        {
            String username = LoginUser.UserName;
            String pass = LoginUser.Password;

            User user=new User();
            user=user.authenticateUser(username, pass);
            

             
            if (user == null)
            {
                LoginUser.FailureText = " Incorrect username/password";
            }
            else
            {
                Session["username"] = username;
                Session["privilege"] = user.getPrivilege();

                if (user.getPrivilege() == 0)
                {
                    Response.Redirect("../docInterface/showProblemsTable.aspx");
                }
                else
                {
                    Response.Redirect("../docInterface/showProblemsTable.aspx");
                }
            }
        }
    }
}
