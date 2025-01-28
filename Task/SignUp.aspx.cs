using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signUp_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("Books.txt");
            if (!File.Exists(file))
            {
                File.Create(file);
            }
            using (StreamWriter sw = new StreamWriter(file,true))
            {
                sw.WriteLine($"{Name.Text} {Email.Text} {Password.Text} ");

            }
            Response.Redirect("Login.aspx");
        }
    }
}