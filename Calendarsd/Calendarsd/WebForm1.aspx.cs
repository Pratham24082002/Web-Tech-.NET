using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calendarsd
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            label1.Text = Calendar1.TodaysDate.ToString();
            label2.Text = Calendar1.Caption.ToString();

            if (Calendar1.SelectedDate.ToShortDateString() == "17-03-2024")
            {
                label3.Text = "<b>HOLIDAY BITHCES<b>";
            }
            else {
                label3.Text = "";
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            label1.Text = "Your Selected Date" + Calendar1.SelectedDate.ToString();
            label2.Text =  Calendar1.Caption.ToString();
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date.Day == 5 && e.Day.Date.Month == 9) { 
                e.Cell.BackColor = System.Drawing.Color.AliceBlue;
                Label lbl = new Label();
                lbl.Text = "<br> Teachers Dat";
                e.Cell.Controls.Add(lbl);
                Image img = new Image();
                img.ImageUrl = "./intro-1598364383.jpg";
                img.Height = 50;
                img.Width = 100;
                e.Cell.Controls.Add((Image)img);
            }


            if (e.Day.Date.Day == 25 && e.Day.Date.Month == 12)
            {
                e.Cell.BackColor = System.Drawing.Color.AliceBlue;
                Label lbl = new Label();
                lbl.Text = "<br> Chrismas";
                e.Cell.Controls.Add(lbl);
                Image img = new Image();
                img.ImageUrl = "./intro-1598364383.jpg";
                img.Height = 500;
                img.Width = 1000;
                e.Cell.Controls.Add((Image)img);
            }


            if (e.Day.Date.Day == 7 && e.Day.Date.Month == 9)
            {
                DateTime dt = new DateTime(2024, 9, 7);
                Label lbl = new Label();
                lbl.Text = "<br>Ganpati Vacations";
                Calendar1.SelectedDates.SelectRange(dt, dt.AddDays(10));
                e.Cell.Controls.Add(lbl);   
            }
        }
    }
}