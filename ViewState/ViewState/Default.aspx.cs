using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            ViewState["name"] = Name.Text.ToString();
            ViewState["address"] = Addr.Text.ToString();
            Name.Text = "";
            Addr.Text = "";
        }

        protected void BtnRestore_Click(object sender, EventArgs e)
        {
            if (ViewState["name"] != null)
            {
                Name.Text = ViewState["name"].ToString();
            }

            if (ViewState["address"] != null)
            {
                Addr.Text = ViewState["address"].ToString();
            }
        }
    }
}