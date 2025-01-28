using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class ShowRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("RoomsAdded.txt");

            // التحقق إذا كان الملف موجودًا
            if (File.Exists(filePath))
            {
                // قراءة البيانات من الملف
                string[] lines = File.ReadAllLines(filePath);

                // التحقق من أن هناك بيانات في الملف
                if (lines.Length > 0)
                {
                    foreach (var line in lines)
                    {
                        // تقسيم البيانات باستخدام الفاصل (نفترض أن البيانات مفصولة بفواصل)
                        string[] roomData = line.Split(' ');

                        // إضافة الصفوف إلى الجدول
                        string rowHtml = $"<tr><td>{roomData[0]}</td><td>{roomData[1]}</td><td>{roomData[2]}</td><td>{roomData[3]}</td></tr>";
                        RoomTableBody.InnerHtml += rowHtml;
                    }
                }
                else
                {
                    // إذا كان الملف فارغًا
                    RoomTableBody.InnerHtml = "<tr><td colspan='4'>No books available.</td></tr>";
                }
            }
            else
            {
                // إذا كان الملف غير موجود
                RoomTableBody.InnerHtml = "<tr><td colspan='4'>No books available.</td></tr>";
            }
        }
    }
}