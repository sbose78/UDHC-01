using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Healthcare.user;
using System.Web.UI.WebControls;
using Healthcare.patient;
using MySql.Data.MySqlClient;
using System.Data;
using Healthcare.dbcon;

namespace Healthcare.docInterface
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"]==null)
            {
                Response.Redirect("../Account/Login.aspx?redirect="+Request.Url.ToString());
            }

            TextBox2ProblemId.Text = Request.Params["problem_id"];         
            User user=new User();

            TextBox3PatientName.Visible=false;//= Session["username"].ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String sug = TextBox1Suggestion.Text;
            String pid = Request.Params["problem_id"];// TextBox2ProblemId.Text;
            String doc_id = Session["username"].ToString();
            

            Suggestion s = new Suggestion(0,Convert.ToInt32(pid),doc_id,0,sug);
            TextBox1Suggestion.Text= s.insertNewSuggestion();           
        }

        public DataTable getData()
        {


            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = MySQLDatabase.getConnectionString();
            DataTable dt = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("select * from suggestion where problem_id = " + Request.Params["problem_id"]+" ORDER BY suggestion_id ASC", con);
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

    }
}