using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using MySql.Web;
using Healthcare.dbcon;

namespace Healthcare
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = MySQLDatabase.getConnectionString();// "server=localhost;uid=root;pwd=qwerty;database=test";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);

                conn.Open();
                
                String commandText = "insert into student (name,roll) value( ?name , ?roll ) ;";
                MySqlCommand comm = new MySqlCommand(commandText,conn);
                comm.Parameters.Add("?name", MySqlDbType.VarChar).Value = "Nayan";
                comm.Parameters.Add("?roll", MySqlDbType.Int16).Value = 12;

                
                
               
                comm.ExecuteNonQuery();
                conn.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                TextBox1.Text = ex.Message;

            }
            finally
            {

               
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {


            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=localhost;uid=root;pwd=qwerty;database=test";

            byte[] imgByte = new byte[FileUpload1.PostedFile.InputStream.Length + 1];
            FileUpload1.PostedFile.InputStream.Read(imgByte, 0, imgByte.Length);

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);

                conn.Open();

                String commandText = "insert into student (name,roll,pic) value( ?name , ?roll, ?pic ) ;";
                MySqlCommand comm = new MySqlCommand(commandText, conn);
                comm.Parameters.Add("?name", MySqlDbType.VarChar).Value = "Nayan!!!";
                comm.Parameters.Add("?roll", MySqlDbType.Int16).Value = 12;
                comm.Parameters.Add("?pic", MySqlDbType.LongBlob).Value = imgByte;





                comm.ExecuteNonQuery();
                conn.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                TextBox1.Text = ex.Message;

            }
            finally
            {


            }

        }
    }
}
