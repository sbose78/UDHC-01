using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Healthcare.user;
namespace Healthcare.docInterface
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            byte[] imgByte = new byte[FileUpload1User_pic.PostedFile.InputStream.Length + 1];
            FileUpload1User_pic.PostedFile.InputStream.Read(imgByte,0,imgByte.Length);

            String email = TextBoxEmailId.Text;

            User user=new User(TextBox1CareGiverID.Text,1,"",imgByte,email);
            Button1.Text+=  user.insertUser();

            Session["username"] = TextBox1CareGiverID.Text;
            Session["privilege"] = 1;
            Response.Redirect("showProblemsTable.aspx");

        }
    }
}