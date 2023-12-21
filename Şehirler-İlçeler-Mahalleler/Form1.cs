using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şehirler_İlçeler_Mahalleler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cities = new List<string>()
            { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "İçel (Mersin)", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"};
            for (int i = 0; i < 80; i++)
            {
                string item = cities[i];
                sehirler.Items.Add(item);
            }
        }

        private void sehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceler.Items.Clear();
            mahalleler.Items.Clear();
            string sehir = sehirler.SelectedItem.ToString();
            if (sehir == "Karaman")
            {
                string[] districts = { "Ayrancı", "Ermenek", "Sarıveliler", "Kazımkarabekir", "Merkez" };
                foreach (string item in districts)
                {
                    ilceler.Items.Add(item);
                }
            }

        }
        private void ilceler_SelectedIndexChanged(object sender, EventArgs e)
        {
            mahalleler.Items.Clear();
            string ilce = ilceler.SelectedItem.ToString();
            if (ilce == "Merkez")
            {
                string[] mah = { "Hürriyet Mah.", "Mümine Hatun Mah.", "Atatürk Mah.", "Kazımkarabekir", "Cumhuriyet Mah." };
                foreach (string item in mah)
                {
                    mahalleler.Items.Add(item);
                }
            }
        }
    }
}
