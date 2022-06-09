using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Digitron
{
    public partial class Form1 : Form
    {
        string Operation;
        int n = 0;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            TB1.Text += B1.Text;
        }

        private void B2_Click(object sender, EventArgs e)
        {

            TB1.Text += B2.Text;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            TB1.Text += B3.Text;
        }

        private void B4_Click(object sender, EventArgs e)
        {
            TB1.Text += B4.Text;
        }

        private void B5_Click(object sender, EventArgs e)
        {
            TB1.Text += B5.Text;
        }

        private void B6_Click(object sender, EventArgs e)
        {
            TB1.Text += B6.Text;
        }

        private void B7_Click(object sender, EventArgs e)
        {
            TB1.Text += B7.Text;
        }

        private void B8_Click(object sender, EventArgs e)
        {
            TB1.Text += B8.Text;
        }

        private void B9_Click(object sender, EventArgs e)
        {
            TB1.Text += B9.Text;
        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void BC_Click(object sender, EventArgs e)
        {
            n = 0;
            TB1.Text="";
            L2.Text = " 0";
           
        }

        private void BS_Click(object sender, EventArgs e)
        {
            
            if (n > 1)
            {
                TB1.Text = "Greska";
            }

            else if (TB1.Text == "")
            {
                L2.Text = Convert.ToString(Convert.ToDouble(L2.Text) + 0);
                Operation = "+";
                TB1.Clear();
            }
            else
            {
                Operation = "+";
                L2.Text = Convert.ToString(Convert.ToDouble(TB1.Text) + Convert.ToDouble(L2.Text));
                TB1.Clear();
            }
            
            
        }

        private void BJ_Click(object sender, EventArgs e)
        {

            {
                if (Operation == "+")
                {

                    TB1.Text = Convert.ToString(Convert.ToDouble(L2.Text) + Convert.ToDouble(TB1.Text));
                    L2.Text = "0";
                }
                if (Operation == "-")
                {
                    TB1.Text = Convert.ToString(Convert.ToDouble(L2.Text) - Convert.ToDouble(TB1.Text));
                    L2.Text = "0";
                }
                if (Operation == "*")
                {
                    TB1.Text = Convert.ToString(Convert.ToDouble(L2.Text) * Convert.ToDouble(TB1.Text));
                    L2.Text = "0";
                }
                if (Operation == "/")
                {
                    if (TB1.Text == "0")
                    {
                        TB1.Text="Nije dozvoljeno dijeliti sa nulom!!!";
                    }
                    else{
                        TB1.Text = Convert.ToString(Convert.ToDouble(L2.Text) / Convert.ToDouble(TB1.Text));
                    }
                    L2.Text = "0";
                }
            }
        }

        private void L1_Click(object sender, EventArgs e)
        {

        }

        private void BO_Click(object sender, EventArgs e)
        {
            
            if (n > 1)
            {
                TB1.Text = "Greska";
            }
            else if (TB1.Text == "")
            {
                n = 0;
                L2.Text = Convert.ToString(Convert.ToDouble(L2.Text) - 0);
                Operation = "-";
                TB1.Clear();
            }
            else
            {
                n = 0;
                Operation = "-";
                L2.Text = (Convert.ToString(Convert.ToDouble(TB1.Text) - Convert.ToDouble(L2.Text)));
                TB1.Clear();
            }
        }

        private void BM_Click(object sender, EventArgs e)
        {
            
            if (n > 1)
            {
                TB1.Text = "Greska";
            }
            else if (TB1.Text == "")
            {
                n = 0; 
                L2.Text = Convert.ToString(Convert.ToDouble(L2.Text) * 1);
                Operation = "*";
                TB1.Clear();
            }
            else
            {
                n = 0;
                Operation = "*";
                L2.Text = Convert.ToString(Convert.ToDouble(TB1.Text) * 1);
                TB1.Clear();
            }
        }

        private void B0_Click(object sender, EventArgs e)
        {
            TB1.Text += B0.Text;
        }

        private void BD_Click(object sender, EventArgs e)
        {
           
            if (n > 1)
            {
                TB1.Text = "Greska";
            }
            else if (TB1.Text == "")
            {
                n = 0;
                L2.Text = Convert.ToString(Convert.ToDouble(L2.Text) / 1);
                Operation = "/";
                TB1.Clear();
            }
            else
            {
                n = 0;
                Operation = "/";
                L2.Text = Convert.ToString(Convert.ToDouble(TB1.Text) / 1);
                TB1.Clear();
            }
        }

        private void BCE_Click(object sender, EventArgs e)
        {
            if (TB1.Text.Length > 0)
            {
                n = 0;
                TB1.Text = TB1.Text.Remove(TB1.Text.Length - 1, 1);
            }
            if(TB1.Text=="")
            {
                n = 0;
                TB1.Text="";
            }
        }

        private void BZ_Click(object sender, EventArgs e)
        {
            TB1.Text += ",";
            n+=1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
