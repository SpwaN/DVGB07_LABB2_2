using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVGB07_LABB2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string Text = tbxDisplay.Text;
            tbxDisplay.Text = Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string Text = tbxDisplay.Text;
            tbxDisplay.Text = Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string Text = tbxDisplay.Text;
            tbxDisplay.Text = Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string Text = tbxDisplay.Text;
            tbxDisplay.Text = Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string Text = tbxDisplay.Text;
            tbxDisplay.Text = Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string Text = tbxDisplay.Text;
            tbxDisplay.Text = Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string Text = tbxDisplay.Text;
            tbxDisplay.Text = Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string Text = tbxDisplay.Text;
            tbxDisplay.Text = Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string Text = tbxDisplay.Text;
            tbxDisplay.Text = Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string Text = tbxDisplay.Text;
            tbxDisplay.Text = Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Text = tbxDisplay.Text;
            tbxDisplay.Text = Text + "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            string Text = tbxDisplay.Text;
            tbxDisplay.Text = Text + "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            string Text = tbxDisplay.Text;
            tbxDisplay.Text = Text + "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            string Text = tbxDisplay.Text;
            tbxDisplay.Text = Text + "/";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            char[] splitters = { '/', '*', '+', '-' };
            string Text = tbxDisplay.Text;

            List<char> operatorsList = new List<char>();
            int antalOperators = 0;
            foreach (char c in Text)
            {
                if (c == '*' || c == '/' || c == '+' || c == '-')
                {
                    operatorsList.Add(c);
                    antalOperators++;
                 }
            }

            string[] numbers = Text.Split(splitters);
            int sum = 0;
            for (int i = 0; i < antalOperators; i++)
            {
                if (i == 0)
                {
                    if (operatorsList[i] == '+')
                    {
                        sum = Int32.Parse(numbers[i]) + Int32.Parse(numbers[i + 1]);
                    }
                    else if (operatorsList[i] == '-')
                    {
                        sum = Int32.Parse(numbers[i]) - Int32.Parse(numbers[i + 1]);
                    }
                    else if (operatorsList[i] == '*')
                    {
                        sum = Int32.Parse(numbers[i]) * Int32.Parse(numbers[i + 1]);
                    }
                    else if (operatorsList[i] == '/')
                    {
                        sum = Int32.Parse(numbers[i]) / Int32.Parse(numbers[i + 1]);
                    }
                } else if (i != 0)
                {
                    if (operatorsList[i] == '+')
                    {
                        sum = sum + Int32.Parse(numbers[i + 1]);
                    } 
                    else if (operatorsList[i] == '-')
                    {
                        sum = sum - Int32.Parse(numbers[i + 1]);
                    }
                    else if (operatorsList[i] == '*')
                    {
                        sum = sum * Int32.Parse(numbers[i + 1]);
                    }
                    else if (operatorsList[i] == '/')
                    {
                        sum = sum / Int32.Parse(numbers[i + 1]);
                    }
                }
            }
            tbxSum.Text = sum.ToString();
        }
    }
}
