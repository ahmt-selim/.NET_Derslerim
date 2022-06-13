using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    class Esittir
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Sonuc()
        {
            try
            {
                double sonuc = 0;
                double sayi1 = double.Parse(Form.lblGoster.Text.Substring(0, lblGoster.Text.Length - 3));
                double sayi2 = double.Parse(txtText.Text);
                foreach (char item in lblGoster.Text)
                {
                    if (item.ToString() == "+")
                    {
                        sonuc = sayi1 + sayi2;
                    }
                    if (item.ToString() == "-")
                    {
                        sonuc = sayi1 - sayi2;
                    }
                    if (item.ToString() == "*")
                    {
                        sonuc = sayi1 * sayi2;
                    }
                    if (item.ToString() == "/")
                    {
                        sonuc = sayi1 / sayi2;
                    }
                    if (item.ToString() == "√")
                    {
                        //double d =Math.Pow(sayi2, 0.5);
                        //if (sayi1==null)
                        //{
                        //    sayi1 = 1;
                        //}
                        sonuc = sayi1 * Math.Sqrt(sayi2);
                    }
                    if (item.ToString() == "^")
                    {
                        sonuc = Math.Pow(sayi1, sayi2);
                    }

                }
                lblGoster.Text = lblGoster.Text + sayi2.ToString() + " = ";
                txtText.Text = sonuc.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu.");
            }
        }
    }
}
