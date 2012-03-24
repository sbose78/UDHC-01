using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Healthcare.user;
using Healthcare.patient_naming;
using System.Web.UI.WebControls;

namespace Healthcare.user
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PatientNaming pn = new PatientNaming();
            String username= pn.getUniqueName();
            User user = new User(username, 0, "http://www.", null,"");
            Button1.Text+=user.insertUser();
            Session["username"] = username;
            Session["privilege"] = 0;

            Response.Redirect("../careSeekersUI.aspx");
        }
    }
}