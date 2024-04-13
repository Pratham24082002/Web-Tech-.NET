using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnidSubmit_Click(object sender, EventArgs e)
        {
            ViewState["name"] = txtname.Text;
            ViewState["add"] = txtadd.Text;
            ViewState["edu"] = txtedu.Text;

            txtname.Text = txtadd.Text = txtedu.Text = String.Empty;
        }

        protected void btnrestore_Click(object sender, EventArgs e)
        {
            if (ViewState["name"] != null)
            {
                txtname.Text = ViewState["name"].ToString();        
            }
            if (ViewState["add"] != null)
            {
                txtadd.Text = ViewState["add"].ToString();
            }
            if (ViewState["edu"] != null)
            {
                txtedu.Text = ViewState["edu"].ToString();
            }
        }
    }
}