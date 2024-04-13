using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionState
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMove_Click(object sender, EventArgs e)
        {
            Session["uname"] = TextBox1.Text.ToString();
            Session["pass"] = TextBox2.Text.ToString();
            Response.Redirect("./Dash.aspx");
        }
    }
}