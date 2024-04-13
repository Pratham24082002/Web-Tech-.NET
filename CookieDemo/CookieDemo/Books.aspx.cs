using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieDemo
{
    public partial class Books : System.Web.UI.Page
    {
        private Dictionary<string, string> BooksList;

        protected void Page_Init(object sender, EventArgs e)
        {
            BooksList = new Dictionary<string, string>();
            BooksList.Add("1", "La La Land");
            BooksList.Add("2", "La La Land 2");
            BooksList.Add("3", "La La Land 3");
            BooksList.Add("4", "La La Land 4");

            // clear the radiobtnlist
            books.Items.Clear();
            foreach (string key in BooksList.Keys)
            {
                ListItem item = new ListItem { Text = BooksList[key], Value = key };

                books.Items.Add(item);
            }
        }

        protected void Page_Load(object sender, EventArgs e) { }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            if (books.SelectedIndex > -1)
            {
                String bookIDX = books.SelectedValue;
                String bookDESC = BooksList[bookIDX];

                // Cookie
                HttpCookie myCookie = new HttpCookie(bookIDX, bookDESC);
                Response.Cookies.Add(myCookie);
                IsErr.Text = "Book Added";
            }
            else
            {
                IsErr.Text = "No Book Selected";
            }
        }

        protected void BtnDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("./BookDetails.aspx");
        }
    }
}
