using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class AdminCardsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddBooks_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBooks.aspx");
        }

        protected void AddRoom_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddRooms.aspx");
        }

        protected void EditBooks_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditBooks.aspx");
        }
    }
}