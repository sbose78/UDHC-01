using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using Healthcare.dbcon;
using System.Data;
namespace Healthcare.user
{
    public class User
    {
        String user_id;
        String username;
        String image_url;
        int privilege;
        int logged_in;
        byte[] user_pic;
        String email;
        String password;
        int reputation;
        int active;

        public User(String username, int privilege, String image_url, byte[] user_pic,String email)
        {
            
            this.username = username;
            this.privilege = privilege;
            this.image_url = image_url;
            this.user_pic = user_pic;
            this.password = "12345";
            
            if (privilege == 0)
            {
                this.active = 1;
                this.reputation = 0;
                this.email = "";


            }
            else
            {
                this.image_url = "N/A";
                this.email = email;

            }

        }
        public User()
        {
        }
        public User(String user_id, String username, int privilege, String image_url, byte[] user_pic,int active,int reputation,String email)
        {
            
            this.user_id = user_id;
            this.username = username;
            this.privilege = privilege;
            this.image_url = image_url;
            this.user_pic = user_pic;
            this.active = 1;
            this.image_url = "N/A";
            this.reputation = 0;
            this.email = email;
            this.password = "12345";

        }
        public String insertUser()
        {

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = MySQLDatabase.getConnectionString();// "server=localhost;uid=root;pwd=qwerty;database=test";

          
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);

                conn.Open();

                /*
                 * 
                 *  String user_id;
        String username;
        String image_url;
        int privilege;
        int logged_in;
        byte[] user_pic;
        int reputation;
        int active;

                 * 
                 * */

                String commandText = "insert into User" +
                    "(" +

                    "username," +
                    "image_url," +
                    "privilege," +
                    "logged_in," +
                    "user_pic," +
                     "reputation," +
                    "active," +
                    "email,"+
                    "password"+
                    ") " +

                    "values" +
                    "(" +

                    "?username," +
                    "?image_url," +
                    "?privilege," +
                    "?logged_in," +
                    "?user_pic," +
                     "?reputation," +
                    "?active," +
                    "?email,"+
                    "?password"+
                    ") ";



                //String con1="insert into student" + "(name,roll,pic) value( ?name , ?roll, ?pic ) ;";

                MySqlCommand comm = new MySqlCommand(commandText, conn);
                comm.Parameters.Add("?username", MySqlDbType.LongText).Value = this.username;
                comm.Parameters.Add("?image_url", MySqlDbType.LongText).Value = this.image_url;
                comm.Parameters.Add("?privilege", MySqlDbType.Int32).Value = this.privilege;
                comm.Parameters.Add("?logged_in", MySqlDbType.Int32).Value = this.logged_in;
                comm.Parameters.Add("?user_pic", MySqlDbType.LongBlob).Value = this.user_pic;
                comm.Parameters.Add("?reputation", MySqlDbType.Int32).Value =this.reputation;
                comm.Parameters.Add("?active", MySqlDbType.Int32).Value = this.active;
                comm.Parameters.Add("?email", MySqlDbType.LongText).Value = this.email;
                comm.Parameters.Add("?password", MySqlDbType.LongText).Value = this.password;

                comm.ExecuteNonQuery();
                conn.Close();
            }                    
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return ex.ToString();
            }
            return "OK";
        }
        
        public String insertMedicDetails()
        {
            return "OK";
        }

        public  User authenticateUser(String username, String password)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = MySQLDatabase.getConnectionString();
            DataTable dt = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT * FROM user WHERE  username = '" + username + "' and password = '" + password + "'", con);            //     MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT pic FROM student WHERE  (name = '"+nameauto+"') ", con);
            adpt.Fill(dt);

            User user = new User();
            if (dt.Rows.Count != 0)
            {
                String user_id1=null;
                
                String image_url1;
                int privilege1;
                int logged_in1;
                byte[] user_pic1={1,2};
                int reputation1;
                int active1;

              
/*

                if (dt.Rows[dt.Rows.Count - 1]["user_pic"] != null)
                {
                    user_pic1 = (byte[])dt.Rows[dt.Rows.Count - 1]["user_pic"];
                }
                else
                {
                    user_pic1 = null;
                }
 * */
                user_id1 = dt.Rows[dt.Rows.Count - 1]["userid"].ToString();
                image_url1 = dt.Rows[0]["image_url"].ToString();
                privilege1 = (int)dt.Rows[0]["privilege"];
                logged_in1 = (int)dt.Rows[0]["logged_in"];
                reputation1 = (int)dt.Rows[0]["reputation"];
                active1 = (int)dt.Rows[0]["active"];

                new User(user_id1, username, privilege1, image_url1, user_pic1, active1,reputation1,""       );
                return user;

            }


            return null;
        }
        public int getPrivilege()
        {
            return this.privilege;
        }

        public int getUserById(int id)
        {

            return 2;
        }

    }
}