using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                string file = Server.MapPath("Books.txt");
                string loginuserfile = Server.MapPath("loginuser.txt");
                string[] users = File.ReadAllLines(file);
                string[] loginuser = File.ReadAllLines(loginuserfile);

                foreach (string user in users)
                {
                    string[] userData = user.Split(' ');
                    if (userData[1] == loginuser[0])
                    {
                        userName.Text = userData[0]; 
                        userEmail.Text = userData[1]; 
                        break;
                    }
                }
            }



        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            userName.ReadOnly = false;
            userEmail.ReadOnly = false;
            Save.Visible = true;
           
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("Books.txt");
            string loginuserfile = Server.MapPath("loginuser.txt");

            string[] users = File.ReadAllLines(file);
            string[] loginuser = File.ReadAllLines(loginuserfile);

            for (int i = 0; i < users.Length; i++)
            {
                string[] userData = users[i].Split(' ');
                if (userData[1] == loginuser[0]) 
                {
                    users[i] = $"{userName.Text} {userEmail.Text}"; 
                    loginuser[0] = userEmail.Text; 

                    File.WriteAllLines(file, users);
                    File.WriteAllLines(loginuserfile, loginuser); 

                    break;
                }
            }

            
            Page_Load(null, null);
        }
    }
}