using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ilk değişiklik yapıldı.
        private void button1_Click(object sender, EventArgs e)
        { 
                txtText.Text = txtText.Text + "1";  
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (txtText.Text != null || txtText.Text != "")
            {
                lblGoster.Text = txtText.Text + " - ";
            }
            txtText.Clear();
        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtText.Text!=null || txtText.Text!="")
            {
                lblGoster.Text = txtText.Text + " + ";
            }
            txtText.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtText.Text = txtText.Text + "5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtText.Text = txtText.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtText.Text = txtText.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtText.Text = txtText.Text + "4";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtText.Text = txtText.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtText.Text = txtText.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtText.Text = txtText.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtText.Text = txtText.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtText.Text == "0" || txtText.Text == null)
            {
                txtText.Text = "0";
            }
            else
            {
                txtText.Text = txtText.Text + "0";
            }
            
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            if (txtText.Text != "" && txtText.Text != null)
            {
                int sayac = 0;
                foreach (char item in txtText.Text)
                {
                    if (item.ToString() == ",")
                    {
                        sayac += 1;
                    }
                }
                if (sayac == 0)
                {
                    txtText.Text = txtText.Text + ",";
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                string degisken = txtText.Text.Substring(0, txtText.Text.Length - 1);

                txtText.Text = degisken;
            }
            catch (Exception)
            {

            }          
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
            lblGoster.Text = "";
            txtText.Clear();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (txtText.Text != null || txtText.Text != "")
            {
                lblGoster.Text = txtText.Text + " / ";
            }
            txtText.Clear();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            if (txtText.Text != null || txtText.Text != "")
            {
                lblGoster.Text = txtText.Text + " * ";
            }
            txtText.Clear();//√¯
        }

        private void btnKarekok_Click(object sender, EventArgs e)
        {
            if (txtText.Text != null || txtText.Text != "")
            {
                lblGoster.Text = txtText.Text + " √¯ ";
            }
            txtText.Clear();
        }

        private void btnUsAlma_Click(object sender, EventArgs e)
        {
            if (txtText.Text != null || txtText.Text != "")
            {
                lblGoster.Text = txtText.Text + " ^ ";
            }
            txtText.Clear();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtText.Text = Math.PI.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            lblGoster.Text = txtText.Text + " / " + "2";
            txtText.Text = (double.Parse(txtText.Text) / 2).ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (txtText.Text != "")
            {
                lblGoster.Text = txtText.Text + " % ";
            }
            
        }
    }
}
