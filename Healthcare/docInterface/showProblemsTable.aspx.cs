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
                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT patient_data_id,nameauto,mainHealthIssue FROM patient_data ORDER BY patient_data_id DESC", con);
                adpt.Fill(dt);
                con.Close();
                return dt;    

        }

        public String getProperString(String nameauto1)
        {
            int j;
            for (j = 0; j < nameauto1.Length; j++)
            {
                if (nameauto1[j] != '#' && nameauto1[j] != ' ')
                {
                    break;
                }

            }

            nameauto1 = nameauto1.Substring(j);
            return nameauto1;
        }

    }
}