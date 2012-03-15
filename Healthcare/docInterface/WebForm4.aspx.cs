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
            String name=Request.Params["nameauto"];

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = MySQLDatabase.getConnectionString();
            DataTable dt = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT * FROM patient_data where nameauto = '"+name+"'", con);
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

    }
}