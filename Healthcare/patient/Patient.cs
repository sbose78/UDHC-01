using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


using Healthcare.dbcon;
namespace Healthcare
{
    public class Patient
    {
        String nameauto;
        String age;
        String gender;
        String marital;
        String mainHealthIssue;
        String duration;
        String description;
        String degree1;
        String degree2;
        String comments;
        String treatment;
        String problemsInThePast;
        String isTreatmentTaken;
        String majorIllness;
        String chronicIssue;
        String allergies;
        String familyMainComplaint;
        String familyChronic;
        byte[] imgByte;
        Boolean isImgPresent;

        public Patient(String nameauto,
            String age,
            String gender,
            String marital,
            String mainHealthIssue,
            String duration,
            String description,
            String degree1,
            String degree2,
            String comments,
            String treatment,
            String problemsInThePast,
            String isTreatmentTaken,
            String majorIllness,
            String chronicIssue,
            String allergies,
            String familyMainComplaint,
            String familyChronic,
            byte[] imgByte,
            Boolean isImgPresent

        )
        {

            this.nameauto = nameauto;
            this.gender = gender;
            this.marital = marital;
            this.mainHealthIssue = mainHealthIssue;
            this.duration = duration;
            this.description = description;
            this.degree1 = degree1;
            this.degree2 = degree2;
            this.comments = comments;
            this.treatment = treatment;
            this.problemsInThePast = problemsInThePast;
            this.treatment = treatment;
            this.isTreatmentTaken = isTreatmentTaken;
            this.majorIllness = majorIllness;
            this.chronicIssue = chronicIssue;
            this.allergies = allergies;
            this.familyChronic = familyChronic;
            this.familyMainComplaint = familyMainComplaint;
            this.imgByte = imgByte;
            this.isImgPresent = isImgPresent;

        }

        public Patient[] getPatientRecords()
        {
            return new Patient[4];
        }

        public String insertPatientData()
        {

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = MySQLDatabase.getConnectionString();// "server=localhost;uid=root;pwd=qwerty;database=test";

            /*
            byte[] imgByte = new byte[FileUpload1.PostedFile.InputStream.Length + 1];
            FileUpload1.PostedFile.InputStream.Read(imgByte, 0, imgByte.Length); */

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);

                conn.Open();

                String commandText = "insert into patient_data"+
                    "("+

                    "nameauto," +
                    "age," +
                    "gender," +
                    "marital," +
                    "mainHealthIssue," +
                    "duration," +
                    "description," +
                    "degree1," +
                    "degree2," +
                    "comments," +
                    "treatment," +
                    "problemsInThePast," +
                    "isTreatmentTaken," +
                    "majorIllness," +
                    "chronicIssue," +
                    "allergies," +
                    "familyMainComplaint," +
                    "familyChronic," +
                     "imgByte," +
                    "isImgPresent" +
                    ") "+
                    
                    "values"+
                    "("+

                    "?nameauto," +
                    "?age," +
                    "?gender," +
                    "?marital," +
                    "?mainHealthIssue," +
                    "?duration," +
                    "?description," +
                    "?degree1," +
                    "?degree2," +
                    "?comments," +
                    "?treatment," +
                    "?problemsInThePast," +
                    "?isTreatmentTaken," +
                    "?majorIllness," +
                    "?chronicIssue," +
                    "?allergies," +
                    "?familyMainComplaint," +
                    "?familyChronic," +
                     "?imgByte," +
                    "?isImgPresent" +
                    ");" ;              


                //String con1="insert into student" + "(name,roll,pic) value( ?name , ?roll, ?pic ) ;";

                MySqlCommand comm = new MySqlCommand(commandText, conn);
                comm.Parameters.Add("?nameauto", MySqlDbType.LongText).Value = nameauto;
                comm.Parameters.Add("?age", MySqlDbType.Int32).Value = Convert.ToInt32( age);
                comm.Parameters.Add("?gender", MySqlDbType.LongText).Value = gender;
                comm.Parameters.Add("?marital", MySqlDbType.LongText).Value = marital;
                comm.Parameters.Add("?mainHealthIssue", MySqlDbType.LongText).Value = mainHealthIssue;
                comm.Parameters.Add("?duration", MySqlDbType.LongText).Value = duration;
                comm.Parameters.Add("?description", MySqlDbType.LongText).Value = description;
                comm.Parameters.Add("?degree1", MySqlDbType.LongText).Value = degree1;
                comm.Parameters.Add("?degree2", MySqlDbType.LongText).Value = degree2;
                comm.Parameters.Add("?comments", MySqlDbType.LongText).Value = comments;
                comm.Parameters.Add("?treatment", MySqlDbType.LongText).Value = treatment;
                comm.Parameters.Add("?problemsInThePast", MySqlDbType.LongText).Value = problemsInThePast;
                comm.Parameters.Add("?isTreatmentTaken", MySqlDbType.LongText).Value = isTreatmentTaken;
                comm.Parameters.Add("?majorIllness", MySqlDbType.LongText).Value = majorIllness;
                comm.Parameters.Add("?chronicIssue", MySqlDbType.LongText).Value = chronicIssue;
                comm.Parameters.Add("?allergies", MySqlDbType.LongText).Value = allergies;
                comm.Parameters.Add("?familyMainComplaint", MySqlDbType.LongText).Value = familyMainComplaint;
                comm.Parameters.Add("?familyChronic", MySqlDbType.LongText).Value = familyChronic;
                comm.Parameters.Add("?imgByte", MySqlDbType.LongBlob).Value = imgByte;
                comm.Parameters.Add("?isImgPresent", MySqlDbType.LongText).Value = isImgPresent;

                comm.ExecuteNonQuery();
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