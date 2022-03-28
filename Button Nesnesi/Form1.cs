using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Nesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Button yenibuton1 = new Button(); //Buton nesnesi tanımlama.
            yenibuton1.Text = "Yeni Buton";
            yenibuton1.BackColor = Color.Blue;
            yenibuton1.ForeColor = Color.Red;
            //Konum belirtme
            yenibuton1.Top = button1.Top+10+button1.Height;
            yenibuton1.Left = button1.Left+5;

            this.Controls.Add(yenibuton1); //Bu formdan bahsederken form1 değilde 'this' diye kullanırız.
        }
        int sayac = 0; //Buton sayısını denetlemek için oluşturuldu.
        int sayac2 = 0; //Oluşturulan butonların Y konumunu belirlemek için oluşturuldu.
        private void button2_Click(object sender, EventArgs e)
        {
            Button yenibuton2 = new Button();
            yenibuton2.Text = "Yeni Buton";
            yenibuton2.BackColor = Color.Green;
            yenibuton2.ForeColor = Color.Blue;            

            if (sayac == 10)
            {
                MessageBox.Show("10 tane yeni buton oluşturuldu.");
            }
            else
            {
                yenibuton2.Top = button2.Top + sayac2+10+button2.Height;
                yenibuton2.Left = button2.Left+5;

                this.Controls.Add(yenibuton2);
                sayac2 += 5 + yenibuton2.Height;
                sayac += 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button[] buttondizisi = new Button[10];
            for (int i = 0; i < 10; i++)
            {
                buttondizisi[i] = new Button();
                buttondizisi[i].Text = (i + 1).ToString() + ". Buton";
                buttondizisi[i].BackColor = Color.Yellow;
                buttondizisi[i].Left = button3.Left+5;
                buttondizisi[i].Top = button3.Top+5+button3.Height + (i * 25);               

                this.Controls.Add(buttondizisi[i]);
            }
        }
    }
}
