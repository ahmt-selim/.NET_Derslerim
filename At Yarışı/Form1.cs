using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Left = 50;
            label2.Left = 12;
            pictureBox2.Left = 50;
            label3.Left = 12;
            pictureBox3.Left = 50;
            label4.Left = 12;
            pictureBox4.Left = 50;
            label5.Left = 12;
            pictureBox5.Left = 50;
            label6.Left = 12;

            textBoxthmn1.Clear();
            textBoxthmn2.Clear();
            textBoxthmn3.Clear();
            textBoxthmn4.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = "Yarış Başladı";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "Yarış Durdu";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int rnd1 = random.Next(1, 15);
            int rnd2 = random.Next(1, 15);
            int rnd3 = random.Next(1, 15);
            int rnd4 = random.Next(1, 15);
            int rnd5 = random.Next(1, 15);
            pictureBox1.Left += rnd1;
            label2.Left =pictureBox1.Left-label2.Width;
            pictureBox2.Left += rnd2;
            label3.Left =pictureBox2.Left-label3.Width;
            pictureBox3.Left += rnd3;
            label4.Left =pictureBox3.Left-label4.Width;
            pictureBox4.Left += rnd4;
            label5.Left =pictureBox4.Left-label5.Width;
            pictureBox5.Left += rnd5;
            label6.Left =pictureBox5.Left-label6.Width;

            int kazanan = -1;
            if ((pictureBox1.Left + pictureBox1.Width) >= panel1.Left)
            {
                timer1.Stop();
                label1.Text = "Yarış Bitti";
                MessageBox.Show("Yarışı 1. At Kazandı.");
                kazanan = 1;
            }
            else if ((pictureBox2.Left + pictureBox2.Width) >= panel1.Left)
            {
                timer1.Stop();
                label1.Text = "Yarış Bitti";
                MessageBox.Show("Yarışı 2. At Kazandı.");
                kazanan = 2;
            }
            else if ((pictureBox3.Left + pictureBox3.Width) >= panel1.Left)
            {
                timer1.Stop();
                label1.Text = "Yarış Bitti";
                MessageBox.Show("Yarışı 3. AT Kazandı.");
                kazanan = 3;
            }
            else if ((pictureBox4.Left + pictureBox4.Width) >= panel1.Left)
            {
                timer1.Stop();
                label1.Text = "Yarış Bitti";
                MessageBox.Show("Yarışı 4. AT Kazandı.");
                kazanan = 4;
            }
            else if ((pictureBox5.Left + pictureBox5.Width) >= panel1.Left)
            {
                timer1.Stop();
                label1.Text = "Yarış Bitti";
                MessageBox.Show("Yarışı 5. AT Kazandı.");
                kazanan = 5;
            }
            if (textBoxthmn1.Text=="")
            {
                textBoxthmn1.Text = "0";
            }
            if (textBoxthmn2.Text == "")
            {
                textBoxthmn2.Text = "0";
            }
            if (textBoxthmn3.Text == "")
            {
                textBoxthmn3.Text = "0";
            }
            if (textBoxthmn4.Text == "")
            {
                textBoxthmn4.Text = "0";
            }
            int thmn1 = Convert.ToInt32(textBoxthmn1.Text);
            int thmn2 = Convert.ToInt32(textBoxthmn2.Text);
            int thmn3 = Convert.ToInt32(textBoxthmn3.Text);
            int thmn4 = Convert.ToInt32(textBoxthmn4.Text);
            int puan1 = Convert.ToInt32(labelpuan1.Text);
            int puan2 = Convert.ToInt32(labelpuan2.Text);
            int puan3 = Convert.ToInt32(labelpuan3.Text);
            int puan4 = Convert.ToInt32(labelpuan4.Text);

            if (thmn1 == kazanan)
            {
                puan1 += 10;
                labelpuan1.Text = Convert.ToString(puan1);
            }

            if (thmn2 == kazanan)
            {
                puan2 += 10;
                labelpuan2.Text = Convert.ToString(puan2);
            }
            if (thmn3 == kazanan)
            {
                puan3 += 10;
                labelpuan3.Text = Convert.ToString(puan3);
            }
            if (thmn4 == kazanan)
            {
                puan4 += 10;
                labelpuan4.Text = Convert.ToString(puan4);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    
}
