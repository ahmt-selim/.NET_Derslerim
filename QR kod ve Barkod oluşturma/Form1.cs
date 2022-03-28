using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_kod_ve_Barkod_oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(str, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pictureBox1.Image = qrCodeImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str1 = "https://api.whatsapp.com/send?phone=+90"+ textBox2.Text;
            QRCodeGenerator qrGenerator1 = new QRCodeGenerator();
            QRCodeData qrCodeData1 = qrGenerator1.CreateQrCode(str1, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode1 = new QRCode(qrCodeData1);
            Bitmap qrCodeImage1 = qrCode1.GetGraphic(10);
            pictureBox3.Image = qrCodeImage1;
        
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Restorant menüsü için
            string str1 = textBox5.Text;
            QRCodeGenerator qrGenerator1 = new QRCodeGenerator();
            QRCodeData qrCodeData1 = qrGenerator1.CreateQrCode(str1, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode1 = new QRCode(qrCodeData1);
            Bitmap qrCodeImage1 = qrCode1.GetGraphic(10);
            pictureBox5.Image = qrCodeImage1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "tel:+90"+textBox3.Text;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(str, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pictureBox6.Image = qrCodeImage;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = "mailto:" + textBox4.Text;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(str, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pictureBox4.Image = qrCodeImage;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}

