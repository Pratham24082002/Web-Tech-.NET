using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Next : Form
    {
        public Next()
        {
            InitializeComponent();
        }

        private void chkList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
