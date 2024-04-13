using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies
{
    public partial class Books : System.Web.UI.Page
    {

        Dictionary<string, string> books;

        protected void Page_Init(object sender, EventArgs e)
        {
            books = new Dictionary<string, string>();
            books.Add("C++","bjarne");
            books.Add("C", "Mitchell");
            books.Add("Python", "Dennis");


            rblbooks.Items.Clear();
                foreach (String s in books.Keys)
            {
                rblbooks.Items.Add(s);
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rblbooks.SelectedIndex > 0)
            {
                //get the   selected book
                String bn = rblbooks.SelectedValue;
                String desc = books[bn];

                HttpCookie c1 = new HttpCookie(bn, desc);
                
                //add cookie to response
                Response.Cookies.Add(c1);   
            }

            else
            {
                Label1.Text = "Please Select a book";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}