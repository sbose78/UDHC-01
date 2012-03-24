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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            String patient_data_id = Request.Params["patient_data_id"];
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = MySQLDatabase.getConnectionString();
            DataTable dt = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT imgByte FROM patient_data WHERE  patient_data_id = " + patient_data_id , con);

       //     MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT pic FROM student WHERE  (name = '"+nameauto+"') ", con);

            adpt.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                byte[] data = (byte[])dt.Rows[dt.Rows.Count -1]["imgByte"];
                Response.ContentType = "image/jpeg";
                Response.BinaryWrite(data);
                con.Close();                
            }
            else
            {
                Response.Write("nothing");
                System.Web.HttpContext.Current.Response.Write("<SCRIPT>alert('Hello this is an Alert" + patient_data_id + "')</SCRIPT>");
            }
        }

    }
}