using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MySql.Data;
using Healthcare.dbcon;
using System.Data;

namespace Healthcare
{    public class PatientNaming
    {   public String getUniqueName()
        {
            String unique_name;
            unique_name = "-1";

          

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = MySQLDatabase.getConnectionString();
                DataTable dt = new DataTable();
                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT name FROM scientific_names where used = 0", con);

               
                adpt.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    unique_name = dt.Rows[0]["name"].ToString();
                    con.Close();

                    con = new MySqlConnection();
                    con.ConnectionString = MySQLDatabase.getConnectionString();
                    con.Open();               

                    String commandText =" UPDATE scientific_names SET used = 1 WHERE ( name = '" + unique_name + "')";
                    MySqlCommand comm = new MySqlCommand(commandText, con);
                    comm.ExecuteNonQuery();
                    con.Close();

                }
                String nameauto1 = unique_name;
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

        public String insertNames(String[] names)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = MySQLDatabase.getConnectionString();// "server=localhost;uid=root;pwd=qwerty;database=test";
            
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);

                conn.Open();

                for (int i = 0; i < names.Length; i++)
                {

                    String commandText = "insert into scientific_names(name,used) value( ?name , ?used ) ;";
                    MySqlCommand comm = new MySqlCommand(commandText, conn);
                    comm.Parameters.Add("?name", MySqlDbType.LongText).Value = names[i];
                    comm.Parameters.Add("?used", MySqlDbType.Int16).Value = 0;
                    comm.ExecuteNonQuery();
                }
                conn.Close();



            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return ex.ToString();
            }
            return "OK";
        }

    }
}