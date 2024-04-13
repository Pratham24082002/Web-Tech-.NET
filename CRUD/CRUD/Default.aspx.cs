using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ShowRecords();
            }
        }

        protected void CreateS(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exam\Desktop\09_Atharv_Web\CRUD\CRUD\CRUD2.mdf;Integrated Security=True;Connect Timeout=30";
            using (conn = new SqlConnection(strcon))
            {
                conn.Open();

                String stmt = $"INSERT INTO [dbo].[Student] values ('{int.Parse(StudID.Text)}','{StudN.Text}','{DropDownList1.SelectedValue.ToString()}','{Age.Text.ToString()}','{Contact.Text.ToString()}')";

                SqlCommand sqlCommand = new SqlCommand(stmt,conn);
                sqlCommand.ExecuteNonQuery();

                conn.Close();
                ShowRecords();
            }
        }

        protected void DeleteS(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exam\Desktop\09_Atharv_Web\CRUD\CRUD\CRUD2.mdf;Integrated Security=True;Connect Timeout=30";
            using (conn = new SqlConnection(strcon))
            {
                conn.Open();

                String stmt = $"DELETE [dbo].[Student] WHERE Id = '{int.Parse(StudID.Text)}'";

                SqlCommand sqlCommand = new SqlCommand(stmt, conn);
                sqlCommand.ExecuteNonQuery();

                conn.Close();
                ShowRecords();
            }
        }

        protected void UpdateS(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exam\Desktop\09_Atharv_Web\CRUD\CRUD\CRUD2.mdf;Integrated Security=True;Connect Timeout=30";
            using (conn = new SqlConnection(strcon))
            {
                conn.Open();

                String stmt = $"UPDATE [dbo].[Student] SET Id = '{int.Parse(StudID.Text)}', Name = '{StudN.Text}' ,City = '{DropDownList1.SelectedValue.ToString()}',  Age = '{Age.Text.ToString()}', Contact = '{Contact.Text.ToString()}' WHERE Id = '{int.Parse(StudID.Text)}'";

                SqlCommand sqlCommand = new SqlCommand(stmt, conn);
                sqlCommand.ExecuteNonQuery();

                conn.Close();
                ShowRecords();
            }
        }

        protected void ShowRecords()
        {
            SqlConnection conn = null;
            string strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exam\Desktop\09_Atharv_Web\CRUD\CRUD\CRUD2.mdf;Integrated Security=True;Connect Timeout=30";
            using (conn = new SqlConnection(strcon))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[Student]"))
                
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = conn;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
       }
}