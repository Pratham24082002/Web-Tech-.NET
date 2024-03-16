using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Int32 FirstNum;
        String Operator;

        // Operands
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxCal.Text == "1" && textBoxCal.Text != null)
            {
                textBoxCal.Text = "1";
            }
            else
            {
                textBoxCal.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxCal.Text == "2" && textBoxCal.Text != null)
            {
                textBoxCal.Text = "2";
            }
            else
            {
                textBoxCal.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxCal.Text == "3" && textBoxCal.Text != null)
            {
                textBoxCal.Text = "3";
            }
            else
            {
                textBoxCal.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxCal.Text == "4" && textBoxCal.Text != null)
            {
                textBoxCal.Text = "4";
            }
            else
            {
                textBoxCal.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxCal.Text == "5" && textBoxCal.Text != null)
            {
                textBoxCal.Text = "5";
            }
            else
            {
                textBoxCal.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxCal.Text == "6" && textBoxCal.Text != null)
            {
                textBoxCal.Text = "6";
            }
            else
            {
                textBoxCal.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxCal.Text == "7" && textBoxCal.Text != null)
            {
                textBoxCal.Text = "7";
            }
            else
            {
                textBoxCal.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxCal.Text == "8" && textBoxCal.Text != null)
            {
                textBoxCal.Text = "8";
            }
            else
            {
                textBoxCal.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxCal.Text == "9" && textBoxCal.Text != null)
            {
                textBoxCal.Text = "9";
            }
            else
            {
                textBoxCal.Text += "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxCal.Text == "0" && textBoxCal.Text != null)
            {
                textBoxCal.Text = "0";
            }
            else
            {
                textBoxCal.Text += "0";
            }
        }


        private void buttondot_Click(object sender, EventArgs e)
        {
            if (textBoxCal.Text == "0" && textBoxCal.Text != null)
            {
                textBoxCal.Text = ".";
            }
            else
            {
                textBoxCal.Text += ".";
            }
        }


        // Operators
        private void buttonadd_Click(object sender, EventArgs e)
        {
           FirstNum = Convert.ToInt32(textBoxCal.Text);
           textBoxCal.Text = "";
           Operator = "+";
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToInt32(textBoxCal.Text);
            textBoxCal.Text = "";
            Operator = "-";
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToInt32(textBoxCal.Text);
            textBoxCal.Text = "";
            Operator = "*";
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToInt32(textBoxCal.Text);
            textBoxCal.Text = "";
            Operator = "/";
        }


        private void clr_Click(object sender, EventArgs e)
        {
            if (textBoxCal.Text != null)
            {
                textBoxCal.Text = "";
            }
        }

        private void buttonequals_Click(object sender, EventArgs e)
        {
            Int32 SecondNum = Convert.ToInt32(textBoxCal.Text);
            switch(Operator)
            {
                case "+":
                    textBoxCal.Text = (FirstNum + SecondNum).ToString();
                    break;
                case "-":
                    textBoxCal.Text = (FirstNum - SecondNum).ToString();
                    break;
                case "/":
                    if(!SecondNum.Equals(0))
                    {
                        textBoxCal.Text = (FirstNum / SecondNum).ToString();
                    }
                    else
                    {
                        textBoxCal.Text = "Cannot divide by Zero";
                    }
                    break;
                case "*":
                    textBoxCal.Text = (FirstNum * SecondNum).ToString();
                    break;
            }
        }


    }
}
