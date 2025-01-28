using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class EditBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Bind books to the table
                BindBooksTable();

                // Check if a book ID is provided in the query string
                if (Request.QueryString["bookId"] != null)
                {
                    string bookId = Request.QueryString["bookId"];
                    LoadBookDetails(bookId);
                }
            }
        }

        private void BindBooksTable()
        {
            string filePath = Server.MapPath("BooksAdded.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length > 0)
                {
                    foreach (var line in lines)
                    {
                        string[] bookData = line.Split(' ');
                        string rowHtml = $"<tr>" +
                                         $"<td>{bookData[0]}</td>" +
                                         $"<td>{bookData[1]}</td>" +
                                         $"<td>{bookData[2]}</td>" +
                                         $"<td>{bookData[3]}</td>" +
                                         $"<td><a href='EditBooks.aspx?bookId={bookData[0]}' class='btn btn-primary'>Edit</a></td>" +
                                         $"</tr>";
                        booksTableBody.InnerHtml += rowHtml;
                    }
                }
                else
                {
                    booksTableBody.InnerHtml = "<tr><td colspan='5'>No books available.</td></tr>";
                }
            }
            else
            {
                booksTableBody.InnerHtml = "<tr><td colspan='5'>No books available.</td></tr>";
            }
        }

        private void LoadBookDetails(string bookId)
        {
            string filePath = Server.MapPath("BooksAdded.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    string[] bookData = line.Split(' ');

                    if (bookData[0] == bookId)
                    {
                        // Populate the form fields with the book data
                        this.bookId.Text = bookData[0];
                        bookName.Text = bookData[1];
                        bookKind.Text = bookData[2];
                        bookLevel.Text = bookData[3];

                        // Make the form visible
                        editForm.Style["display"] = "block";
                        break;
                    }
                }
            }
        }

        protected void SaveChanges_Click(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("BooksAdded.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                string updatedData = "";

                foreach (string line in lines)
                {
                    string[] bookData = line.Split(' ');

                    if (bookData[0] == bookId.Text)
                    {
                        // Update the book details
                        updatedData += $"{bookId.Text} {bookName.Text} {bookKind.Text} {bookLevel.Text}\n";
                    }
                    else
                    {
                        updatedData += line + "\n";
                    }
                }

                // Write the updated data back to the file
                File.WriteAllText(filePath, updatedData.Trim());

                // Reload the page to reflect the changes
                Response.Redirect("EditBooks.aspx");
            }
        }
    }
}