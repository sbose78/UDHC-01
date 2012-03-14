using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Healthcare.dbcon;
using System.Data;


namespace Healthcare.docInterface
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Panel1.Visible = false;
                Image1.Visible = false;


                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = MySQLDatabase.getConnectionString();
                DataTable dt = new DataTable();
                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT nameauto,mainHealthIssue FROM patient_data", con);
                adpt.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //DropDownList1.DataTextField[i]= dt.Rows[i]["nameauto"].ToString();
                    DropDownList1.Items.Add(dt.Rows[i]["nameauto"].ToString() + "," + dt.Rows[i]["mainHealthIssue"]);
                }
                con.Close();
            }
            else
            {
                
            }
        }

        public void populate(String solution_id)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = MySQLDatabase.getConnectionString();
            DataTable dt = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT solution_id,medic_id FROM solution where problem_id = '"+Label1.Text+"'", con);
            adpt.Fill(dt);

            

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //DropDownList1.DataTextField[i]= dt.Rows[i]["nameauto"].ToString();
                DropDownList2.Items.Add(dt.Rows[i]["solution_id"].ToString()+","+dt.Rows[i]["medic_id"].ToString());

            }
            con.Close();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image1.Visible = true;
            String issue = DropDownList1.SelectedValue;
            char[] separators = new char[1];
            separators[0] = ',';
            String[] vals = issue.Split(separators, 2);

            Label1.Text = vals[0];

            Image1.ImageUrl = "/docInterface/imgdata.aspx?nameauto=" + vals[0];
            //return "/docInterface/imgdata.aspx?nameauto=" + vals[0];
            Panel1.Visible = true;
            populate(Label1.Text);



        }

        //submit solutions
        protected void Button1_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = MySQLDatabase.getConnectionString();// "server=localhost;uid=root;pwd=qwerty;database=test";


            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);

                conn.Open();

                String commandText = "insert into solution(solution_data,medic_id,problem_id) value( ?solution , ?medic_id , ?problem_id) ;";
                MySqlCommand comm = new MySqlCommand(commandText, conn);
                comm.Parameters.Add("?solution_data", MySqlDbType.LongText).Value = "the data";
                comm.Parameters.Add("?medic_id", MySqlDbType.Int32).Value = 12;
                comm.Parameters.Add("?problem_id", MySqlDbType.LongText).Value ="plant name";
                comm.ExecuteNonQuery();
                conn.Close();

                populate(Label1.Text);

              //  Label1.Text = "Nayan!!!";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                solution.Text = ex.ToString();
            }
            finally
            {

                
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = MySQLDatabase.getConnectionString();// "server=localhost;uid=root;pwd=qwerty;database=test";


            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);

                conn.Open();

                String commandText = "insert into solution(solution_data,medic_id,problem_id) value( ?solution_data , ?medic_id , ?problem_id) ;";
                MySqlCommand comm = new MySqlCommand(commandText, conn);
                comm.Parameters.Add("?solution_data", MySqlDbType.LongText).Value = solution.Text;
                comm.Parameters.Add("?medic_id", MySqlDbType.Int32).Value = 12;
                comm.Parameters.Add("?problem_id", MySqlDbType.LongText).Value = Label1.Text;
                comm.ExecuteNonQuery();
                conn.Close();

                Panel1.Visible = true;
                populate(Label1.Text);
                
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                solution.Text = "2.."+ex.ToString();

            }
            finally
            {


            }
            

        }

        protected void solution_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String solution_id=DropDownList2.SelectedValue;
            char[] separators = new char[1];
            separators[0] = ',';
            String[] vals =  solution_id.Split(separators, 2);


            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = MySQLDatabase.getConnectionString();
            DataTable dt = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT solution_data FROM solution where solution_id = " + vals[0] , con);
            adpt.Fill(dt);
            displaySolution.Text = dt.Rows[0]["solution_data"].ToString();            

            con.Close();
        }

        
    }

}