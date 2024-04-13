using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionState
{
    public partial class Dash : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uname"] != null && Session["pass"] != null)
            {
                ID.Text = $"Session ID {Session.SessionID.ToString()}";
                Username.Text = $" Username {Session["uname"].ToString()}";
                Password.Text = $"Password {Session["pass"].ToString()}";
            }
        }
    }
}