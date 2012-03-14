using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Healthcare.patient_naming;
using System.IO;
using System.Collections;

namespace Healthcare.patient_naming
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        protected void Button1_Click(object sender, EventArgs e)
        {
            String bulk_names = TextBox1.Text;
            
            //Stream fs = OpenFile("sci-names.txt");

            StreamReader sr = new StreamReader("sci-names.txt");
            String s="";
            ArrayList a = new ArrayList();
            
            while ((s = sr.ReadLine()) != null)
            {
                TextBox1.Text = TextBox1.Text + ";"+ s;
                a.Add(s);
            }

            String[] names=(String[])a.ToArray(typeof(String));

            PatientNaming pn = new PatientNaming();
            String status=pn.insertNames(names);

            Button1.Text = status;
        }
    }
}