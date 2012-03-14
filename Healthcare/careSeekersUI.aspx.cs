using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Healthcare.dbcon;
using MySql.Data.MySqlClient;
using Healthcare.patient_naming;


namespace Healthcare
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowNamePanel.Visible = false;
            FormQuestionsPanel.Visible = true;
            ImageUploadPanel.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = MySQLDatabase.getConnectionString();// "server=localhost;uid=root;pwd=qwerty;database=test";

            

            byte[] imgByte = new byte[FileUpload1.PostedFile.InputStream.Length + 1];
            FileUpload1.PostedFile.InputStream.Read(imgByte, 0, imgByte.Length);

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);

                conn.Open();

                String commandText = "insert into student(name,roll,pic) value( ?name , ?roll , ?pic) ;";
                MySqlCommand comm = new MySqlCommand(commandText, conn);
                comm.Parameters.Add("?name", MySqlDbType.LongText).Value = "# ACACIA NILOTICA (L.) Willd. ex Del. ssp. INDICA (Benth.) Brenan.";
                comm.Parameters.Add("?roll", MySqlDbType.LongText).Value = "yay";
                comm.Parameters.Add("?pic", MySqlDbType.LongBlob).Value = imgByte;
                comm.ExecuteNonQuery();
                conn.Close();
                
                ShowNamePanel.Visible = true;
                FormQuestionsPanel.Visible = false;
                ImageUploadPanel.Visible = false;

                Label1.Text = "Nayan!!!";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                TextBox1.Text = ex.ToString();
            }
            finally
            {


            }
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String nameauto1 = nameauto.Text;
            String age1 = age.Text;
            String gender1 = gender.Text;
            String marital1 = marital.Text;
            String mainHealthIssue1 = mainHealthIssue.Text;
            String duration1 = duration.Text;
            String description1 = description.Text;
            String degree11 = degree1.Text;
            String degree21 = degree2.Text;
            String comments1 = comments.Text;
            String treatment1=treatment.Text;
            String problemsInThePast1=problemsInThePast.Text;
            String isTreatmentTaken1=isTreatmentTaken.Text;
            String majorIllness1 = majorIllness.Text;
            String chronicIssue1 = chronicIssue.Text;
            String allergies1 = allergies.Text;
            String familyMainComplaint1 = familyMainComplaint.Text;
            String familyChronic1 = familyChronic.Text;
            Boolean isImgPresent = FileUpload1.HasFile;

            PatientNaming pn=new PatientNaming();
            nameauto1 = pn.getUniqueName();

            //find out the first letter
            int j;
            for ( j = 0; j < nameauto1.Length; j++)
            {
                if (nameauto1[j] != '#' && nameauto1[j] != ' ')
                {
                    break;
                }

            }

            nameauto1=nameauto1.Substring(j);
            
            byte[] imgByte;

            if (isImgPresent)
            {
                imgByte = new byte[FileUpload1.PostedFile.InputStream.Length + 1];
                FileUpload1.PostedFile.InputStream.Read(imgByte, 0, imgByte.Length);
            }
            else
            {
                imgByte = null;// new byte[10];
            }


            Patient p = new Patient(nameauto1,
                                    age1,
                                    gender1,
                                    marital1,
                                    mainHealthIssue1,
                                    duration1,
                                    description1,
                                    degree11,
                                    degree21,
                                    comments1,
                                    treatment1,
                                    problemsInThePast1,
                                    isTreatmentTaken1,
                                    majorIllness1,
                                    chronicIssue1,
                                    allergies1,
                                    familyMainComplaint1,
                                    familyChronic1,
                                    imgByte,
                                    isImgPresent);

            TextBox1.Text= p.insertPatientData().ToString();

            Label1.Text = nameauto1;
            

            ShowNamePanel.Visible = true;
            FormQuestionsPanel.Visible = false;
            ImageUploadPanel.Visible = false;


            //insert into database

        }

    }
}