using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieDemo
{
    public partial class BookDetails : System.Web.UI.Page
    {
        HttpCookieCollection cookies;

        protected void Page_Load(object sender, EventArgs e)
        {
            cookies = new HttpCookieCollection();
            cookies = Request.Cookies;
            if (cookies.Count > 0)
            {
                foreach (string key in cookies.Keys)
                {
                    ListItem item = new ListItem() { Text = cookies[key].Value.ToString(), Value = key };
                    SelBooks.Items.Add(item);
                }
            }
        }

    }
}
