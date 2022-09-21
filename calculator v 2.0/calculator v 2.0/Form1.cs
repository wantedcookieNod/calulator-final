using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_v_2._0
{
    public partial class Form1 : Form
    {
        double A, B;

        string C;

        double R;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b0.Text;
            if (C == "")
                A = 0;
            else
                B = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bc_Click(object sender, EventArgs e)
        {
          //  textBox1.Clear();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b2.Text;
            if (C == "")
                A = 2;
            else
                B = 2;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b3.Text;
            if (C == "")
                A = 3;
            else
                B = 3;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b4.Text;
            if (C == "")
                A = 4;
            else
                B = 4;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b5.Text;
            if (C == "")
                A = 5;
            else
                B = 5;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b6.Text;
            if (C == "")
                A = 6;
            else
                B = 6;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b7.Text;
            if (C == "")
                A = 7;
            else
                B = 7;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b8.Text;
            if (C == "")
                A = 8;
            else
                B = 8;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b9.Text;
            if (C == "")
                A = 9;
            else
                B = 9;
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + bdot.Text;
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + bplus.Text;
            C = "+";
        }

        private void bminus_Click(object sender, EventArgs e)
        {
          //  textBox1.Text = textBox1.Text + bminus.Text;
          //  C = "-";
        }

        private void bbbbbb_Click(object sender, EventArgs e)
        {
        //    textBox1.Text = textBox1.Text + bbbbbb.Text;
         //   C = "/";
        }

        private void badd_Click(object sender, EventArgs e)
        {
         //   textBox1.Text = textBox1.Text + badd.Text;
         //   C = "*";
        }

        private void bequals_Click(object sender, EventArgs e)
        {
            switch (C)
            {
                case "+":
                    R = A + B;
                    break;
             //   case "-":
              //      R = A - B;
               //     break;
              //  case "/":
               //     R = A / B;
              //      break;
              //  case "*":
                 //   R = A * B;
                //    break;
              //  default:
              //      textBox1.Text = "wrong";
               //     break;
            }
            textBox1.Text = "" + R;

            }

        private void b1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b1.Text;
            if (C == "")
                A = 1;
            else
                B = 1;
        }
    }
}
