using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies
{
    public partial class BooksDetails : System.Web.UI.Page
    {

        HttpCookieCollection cookies;   
        protected void Page_Load(object sender, EventArgs e)
        {
            //Fetch all cookies
            cookies = Request.Cookies;

            //display cookies in a listbox
            if (cookies.Count > 0)
            {
                for(int i = 0; i<cookies.Count; i++)
                {
                    ListBox1.Items.Add("Book: " + cookies[i].Name + "Author:" + cookies[i].Value);
                }
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
}