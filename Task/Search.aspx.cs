using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Search_Click(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("BooksAdded.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                booksTableBody.InnerHtml = ""; 

                foreach (var line in lines)
                {
                    string[] bookData = line.Split(' ');
                    if (bookData[0] == searchBookId.Text)
                    {
                        string rowHtml = $"<tr>" +
                                         $"<td>{bookData[0]}</td>" +
                                         $"<td>{bookData[1]}</td>" +
                                         $"<td>{bookData[2]}</td>" +
                                         $"<td>{bookData[3]}</td>" +
                                         $"<td><a href='EditBooks.aspx?bookId={bookData[0]}' class='btn btn-primary'>Edit</a></td>" +
                                         $"</tr>";
                        booksTableBody.InnerHtml += rowHtml;
                        return; 
                    }
                }

            }
            booksTableBody.InnerHtml = "<tr><td colspan='5'>No book found with this ID.</td></tr>";

        }


        }
}