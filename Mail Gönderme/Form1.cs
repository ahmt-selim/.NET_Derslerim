using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Gönderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textalici.Text.ToString());
            textalici.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            sc.Credentials = new NetworkCredential(textgndrn.Text.ToString(),textsifre.Text.ToString() );
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(textgndrn.Text.ToString(), textadsoyad.Text.ToString());

            foreach (var item in listBox1.Items)
            {
                mail.To.Add(item.ToString());
            }
            

            mail.Subject = textkonu.Text;
            mail.IsBodyHtml = true;
            mail.Body = textmesaj.Text;

            if (textmesaj.Text != null)
            {
                mail.Attachments.Add(new Attachment(dosyaadi));
            }

            sc.Send(mail);
        }
        string dosyaadi;
        private void btn_gozat_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            dosyaadi = openFileDialog1.FileName;
            textdosya.Text = dosyaadi;
        }
        //List<string> liste = new List<string>(); sanal list oluşturma
        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Add(textadsoyad.Text);
            listBox2.Items.Add(textgndrn.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (checkBox1.Checked)
            {
                //karakteri göster.
                textsifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textsifre.PasswordChar = '*';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
