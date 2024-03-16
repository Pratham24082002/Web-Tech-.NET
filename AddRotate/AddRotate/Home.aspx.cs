using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AddRotate
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn1Click(object sender, EventArgs e) {
            if (FileUpload1.HasFile) {
                FileUpload1.SaveAs(@"D:\Project\" + FileUpload1.FileName);
                label1.Text = "File Uploaded";
            }
            else
            {
                label1.Text = "No File Uploaded";
            }
        }
    }
}