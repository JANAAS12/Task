using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login_Click(object sender, EventArgs e)
        {
           string file=Server.MapPath("Books.txt");
           string[] users =File.ReadAllLines(file);
            foreach (var user in users)
            {
                string[] userData=user.Split(' ');
                if(userData[1] == email.Text && userData[2] == password.Text)
                {
                    result.Text = "login successfully";
                    result.Visible = true;
                    string loginuserfile = Server.MapPath("loginuser.txt");
                    if (!File.Exists(loginuserfile))
                    {
                        File.Create(loginuserfile);

                    }
                    using(StreamWriter sw =new StreamWriter(loginuserfile))
                    {
                        sw.WriteLine($"{email.Text}");
                    }

                    Response.Redirect("CardsPage.aspx");

                }
                if( email.Text == "Admin@gmail.com")
                {
                    Response.Redirect("AdminCardsPage.aspx");
                }
            }
            result.Text = "Invalid username or password ";
            result.Visible = true;
            
        }
    }
}