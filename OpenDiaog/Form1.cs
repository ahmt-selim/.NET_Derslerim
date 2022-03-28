using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenDiaog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxRsm.ImageLocation = openFileDialog1.FileName;
            
        }

        private void fontayarla_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font= fontDialog1.Font;
        }

        private void renkayarla_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }
        List<string> resimler = new List<string>();
        private void rsmdosyasec_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            foreach (string item in openFileDialog2.FileNames)
            {
                resimler.Add(item);
            }
            
        }

        private void slytbslt_Click(object sender, EventArgs e)
        {
            timer1.Start();
            foreach (string item in resimler)
            {
                pictureBoxSlayt.ImageLocation = item;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxSlayt.ImageLocation = resimler[say];
            textBox1.Text = resimler[say];
            if (say<resimler.Count)
            {
                say++;
            }
            else
            {
                say = 0;
            }

        }
        int say=0;
        private void sagagit_Click(object sender, EventArgs e)
        {
            pictureBoxSlayt.ImageLocation=resimler[say];
            if (say<resimler.Count)
            {
                say++;
            }
            else
            {
                say = 0;
            }
        }

        private void solagit_Click(object sender, EventArgs e)
        {
            pictureBoxSlayt.ImageLocation = resimler[say];
            if (say>resimler.Count)
            {
                say--;
            }
            else
            {
                say=0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
