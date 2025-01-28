using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class CardsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SeeAllBooks_Click(object sender, EventArgs e)
        {
           //string file = Server.MapPath("BooksAdded.txt");
           // string outputFile = Server.MapPath("BooksTable.txt");
           // if (File.Exists(file))
           // {
           //     string[] Books = File.ReadAllLines(file);
           //     string tableContent = "ID\tName\tType\tCapacity\n";
                
           //     foreach (string book in Books)
           //     {
           //         string[] details = book.Split(' ');
                    
           //         tableContent += $"{details[0]}\t{details[1]}\t{details[2]} \t{details[3]}\n"; 
           //     }

           //     using (StreamWriter writer = new StreamWriter(outputFile))
           //     {
           //         writer.Write(tableContent);
           //     }

                



           // }
           Response.Redirect("ShowBook.aspx");
        }

        protected void SeeAllRoom_Click(object sender, EventArgs e)
        {
           Response.Redirect("ShowRoom.aspx");
        }
    }
}