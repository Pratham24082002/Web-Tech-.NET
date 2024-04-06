using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cross
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (PreviousPage != null)
            {

                TextBox tb = new TextBox();   
                tb = (TextBox) (PreviousPage.FindControl("TextBox1"));

                Label1.Text = tb.Text;

            }
        }


    }
}