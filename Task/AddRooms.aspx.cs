using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class AddRooms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddRoom_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("RoomsAdded.txt");
            if (!File.Exists(file))
            {
                using (StreamWriter sw = File.CreateText(file))
                {
                    sw.WriteLine($"{RoomId.Text} {RoomName.Text} {Location.Text} {Capacity.Text} ");
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    sw.WriteLine($"{RoomId.Text} {RoomName.Text} {Location.Text} {Capacity.Text} ");
                }

            }
        }
    }
}