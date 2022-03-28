using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosya_yazma_ve_okuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("yazilarim.txt"); //yazilarim.txt yoksa oluşturur varsa üstüne yazar.
            sw.Write(textBox1.Text); //Yazma yapar
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("yazilarim.txt");
            while (!sr.EndOfStream) //text sonuna kadar okuma yapar.
            {
                textBox2.Text += sr.ReadLine()+Environment.NewLine; //Environment.Newline bir satırı okuduktan sonra alt satıra geçer.
            }
            sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
