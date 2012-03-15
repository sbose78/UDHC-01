using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using Healthcare.dbcon;

namespace Healthcare.docInterface
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public DataTable getData()
        {

            

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = MySQLDatabase.getConnectionString();
                DataTable dt = new DataTable();
                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT nameauto,mainHealthIssue FROM patient_data", con);
                adpt.Fill(dt);
                con.Close();
                return dt;    

        }

    }
}