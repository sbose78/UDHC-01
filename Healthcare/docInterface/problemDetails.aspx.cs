using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Healthcare.dbcon;
using MySql.Data.MySqlClient;

namespace Healthcare.docInterface
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public DataTable getAllData()
        {
            String patient_data_id = Request.Params["patient_data_id"];



            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = MySQLDatabase.getConnectionString();
            DataTable dt = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT * FROM patient_data where patient_data_id = " + patient_data_id, con);
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

    }
}