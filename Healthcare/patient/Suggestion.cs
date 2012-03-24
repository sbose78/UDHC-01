using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Healthcare.dbcon;
using MySql.Data.MySqlClient;

namespace Healthcare.patient
{
    public class Suggestion
    {
        int comment_id;
        int problem_id;
        String doc_id;
        String comment;
        int likes;

        public Suggestion()
        {
        }

        public Suggestion(int comment_id, int problem_id, String doc_id, int likes,String comment)
        {
            this.comment_id = comment_id;
            this.problem_id = problem_id;
            this.comment = comment;
            this.doc_id = doc_id;
            this.likes = likes;
        }

        public String insertNewSuggestion()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = MySQLDatabase.getConnectionString();// "server=localhost;uid=root;pwd=qwerty;database=test";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();

                String commandText = "insert into suggestion(problem_id,comment,doc_id,likes) value( ?problem_id , ?comment, ?doc_id , ?likes) ;";

                MySqlCommand comm = new MySqlCommand(commandText,conn);

                comm.Parameters.Add("?problem_id", MySqlDbType.Int32).Value = this.problem_id;
                comm.Parameters.Add("?comment", MySqlDbType.LongText).Value = this.comment;
                comm.Parameters.Add("?doc_id", MySqlDbType.LongText).Value = this.doc_id;
                comm.Parameters.Add("?likes", MySqlDbType.Int32).Value = this.likes;

                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return ex.ToString();
            }
            finally
            {
                
            }
            return "OK";
        }

    }
}