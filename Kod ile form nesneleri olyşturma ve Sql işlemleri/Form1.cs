using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kod_ile_form_nesneleri_olyşturma_ve_Sql_işlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button btnekle = new Button();
        Button btnsil = new Button();
        GroupBox grbx = new GroupBox();
        Button btnveriekle = new Button();
        Button btnverisil = new Button();
        Button btnguncelle = new Button();
        Button btngoster = new Button();
        TextBox txtad = new TextBox();
        TextBox txtsoyad = new TextBox();
        TextBox txttc = new TextBox();
        TextBox txtsinif = new TextBox();
        TextBox txtbolum = new TextBox();
        TextBox txtokul = new TextBox();
        ListBox lstbx = new ListBox();
        ListBox lstgoster = new ListBox();
        TextBox txtid = new TextBox();
        private void Form1_Load(object sender, EventArgs e)
        {
            grbx.Text = "Öğrenci Bilgileri";
            grbx.Font = new Font("Arial", 17, FontStyle.Bold);
            grbx.Top = 20;
            grbx.Left = 20;
            grbx.Width = 800;
            grbx.Height = 600;
            this.Controls.Add(grbx);


            
            btnekle.Text = "Ekle";
            btnekle.Font = new Font("Arial", 13, FontStyle.Bold);
            btnekle.Width = 85;
            btnekle.Height = 40;
            btnekle.Top = 300;
            btnekle.Left = 475;
            btnekle.Click += Btnekle_Click;
            grbx.Controls.Add(btnekle);

            
            btnsil.Text = "Sil";
            btnsil.Font = new Font("Arial", 13, FontStyle.Bold);
            btnsil.Width = 85;
            btnsil.Height = 40;
            btnsil.Top = btnekle.Top;
            btnsil.Left = btnekle.Location.X + btnekle.Width + 5;
            btnsil.Click += Btnsil_Click;
            grbx.Controls.Add(btnsil);

            btnveriekle.Text = "Veritabanına Ekle";
            btnveriekle.Font = new Font("Arial", 9, FontStyle.Bold);
            btnveriekle.Width = 100;
            btnveriekle.Height = 50;
            btnveriekle.Top = btnekle.Location.Y;
            btnveriekle.Left = 25;
            btnveriekle.Click += Btnveriekle_Click;
            grbx.Controls.Add(btnveriekle);

            btnverisil.Text = "Veritabanından Sil";
            btnverisil.Font = new Font("Arial", 9, FontStyle.Bold);
            btnverisil.Width = 100;
            btnverisil.Height = 50;
            btnverisil.Top = btnekle.Location.Y;
            btnverisil.Left = btnveriekle.Location.X + btnveriekle.Width + 5;
            btnverisil.Click += Btnverisil_Click;
            grbx.Controls.Add(btnverisil);

            btnguncelle.Text = "Güncelle";
            btnguncelle.Font = new Font("Arial", 11, FontStyle.Bold);
            btnguncelle.Width = 100;
            btnguncelle.Height = 50;
            btnguncelle.Top = btnekle.Location.Y;
            btnguncelle.Left = btnverisil.Location.X + btnverisil.Width + 5;
            btnguncelle.Click += Btnguncelle_Click;
            grbx.Controls.Add(btnguncelle);

            btngoster.Text = "Göster";
            btngoster.Font = new Font("Arial", 11, FontStyle.Bold);
            btngoster.Width = 100;
            btngoster.Height = 50;
            btngoster.Top = btnekle.Location.Y;
            btngoster.Left = btnguncelle.Location.X + btnguncelle.Width + 5;
            btngoster.Click += Btngoster_Click;
            grbx.Controls.Add(btngoster);

            Label lblad = new Label();
            lblad.Text = "Ad";
            lblad.Font = new Font("Arial", 11, FontStyle.Bold);
            lblad.Top = 55;
            lblad.Left = 45;
            grbx.Controls.Add(lblad);


            txtad.Top = lblad.Top - 10;
            txtad.Left = lblad.Left + 150;
            txtad.Width = 200;
            txtad.Height = 10;
            grbx.Controls.Add(txtad);

            Label lblsoyad = new Label();
            lblsoyad.Text = "Soyad";
            lblsoyad.Font = new Font("Arial", 11, FontStyle.Bold);
            lblsoyad.Top = lblad.Top + 35;
            lblsoyad.Left = 45;
            grbx.Controls.Add(lblsoyad);


            txtsoyad.Top = lblsoyad.Top - 10;
            txtsoyad.Left = lblsoyad.Left + 150;
            txtsoyad.Width = 200;
            txtsoyad.Height = 10;
            grbx.Controls.Add(txtsoyad);

            Label lbltc = new Label();
            lbltc.Text = "TC No";
            lbltc.Font = new Font("Arial", 11, FontStyle.Bold);
            lbltc.Top = lblsoyad.Top + 35;
            lbltc.Left = 45;
            grbx.Controls.Add(lbltc);


            txttc.Top = lbltc.Top - 10;
            txttc.Left = lbltc.Left + 150;
            txttc.Width = 200;
            txttc.Height = 10;
            grbx.Controls.Add(txttc);

            Label lblsinif = new Label();
            lblsinif.Text = "Sınıf";
            lblsinif.Font = new Font("Arial", 11, FontStyle.Bold);
            lblsinif.Top = lbltc.Top + 35;
            lblsinif.Left = 45;
            grbx.Controls.Add(lblsinif);


            txtsinif.Top = lblsinif.Top - 10;
            txtsinif.Left = lblsinif.Left + 150;
            txtsinif.Width = 200;
            txtsinif.Height = 10;
            grbx.Controls.Add(txtsinif);

            Label lblbolum = new Label();
            lblbolum.Text = "Bölüm";
            lblbolum.Font = new Font("Arial", 11, FontStyle.Bold);
            lblbolum.Top = lblsinif.Top + 35;
            lblbolum.Left = 45;
            grbx.Controls.Add(lblbolum);


            txtbolum.Top = lblbolum.Top - 10;
            txtbolum.Left = lblbolum.Left + 150;
            txtbolum.Width = 200;
            txtbolum.Height = 10;
            grbx.Controls.Add(txtbolum);

            Label lblokul = new Label();
            lblokul.Text = "Okul";
            lblokul.Font = new Font("Arial", 11, FontStyle.Bold);
            lblokul.Top = lblbolum.Top + 35;
            lblokul.Left = 45;
            grbx.Controls.Add(lblokul);


            txtokul.Top = lblokul.Top - 10;
            txtokul.Left = lblokul.Left + 150;
            txtokul.Width = 200;
            txtokul.Height = 10;
            grbx.Controls.Add(txtokul);


            lstbx.Top = 45;
            lstbx.Left = 400;
            lstbx.Width = 300;
            lstbx.Height = 250;
            lstbx.Font = new Font("Arial", 8, FontStyle.Bold);
            grbx.Controls.Add(lstbx);

            Label lblid = new Label();
            lblid.Text = "ID";
            lblid.Font = new Font("Arial", 11, FontStyle.Bold);
            lblid.Top = lblokul.Top + 35;
            lblid.Left = 45;
            grbx.Controls.Add(lblid);

            lstgoster.Top = btnveriekle.Location.Y + btnveriekle.Height;
            lstgoster.Left = btnveriekle.Location.X;
            lstgoster.Width = 416;
            lstgoster.Height = 100;
            lstgoster.Font = new Font("Arial", 8, FontStyle.Bold);
            grbx.Controls.Add(lstgoster);

            
            txtid.Top = lblid.Top - 10;
            txtid.Left = lblid.Left + 150;
            txtid.Width = 200;
            txtid.Height = 10;
            grbx.Controls.Add(txtid);
        }

        private void Btngoster_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=Lenovo-PC\SQLEXPRESS;Initial Catalog=OgrenciBilgileri;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from OgrenciBilgileri";

            SqlDataReader dr;
            dr = cmd.ExecuteReader();


            lstgoster.Items.Clear();
            while (dr.Read())
            {
                lstgoster.Items.Add(dr["ID"].ToString()+"- "+dr["Ad"].ToString() + " " +dr["Soyad"].ToString()+" - "+dr["TC"].ToString()+" - "+dr["Sinif"].ToString()+" - "+dr["Bolum"].ToString() + " - " + dr["Okul"].ToString());
            }
        }

        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=Lenovo-PC\SQLEXPRESS;Initial Catalog=OgrenciBilgileri;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update OgrenciBilgileri set Ad=@Ad,Soyad=@Soyad,TC=@TC,Sinif=@Sinif,Bolum=@Bolum,Okul=@Okul where ID=@ID";
            cmd.Parameters.AddWithValue("@Ad", txtad.Text);
            cmd.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@TC", txttc.Text);
            cmd.Parameters.AddWithValue("@Sinif", txtsinif.Text);
            cmd.Parameters.AddWithValue("@Bolum", txtbolum.Text);
            cmd.Parameters.AddWithValue("@Okul", txtokul.Text);
            cmd.Parameters.AddWithValue("@ID", txtid.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("İşlem Başarılı.");
            }
            else
            {
                MessageBox.Show("İşlem Başarısız!!!");
            }

            foreach (Control item in grbx.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
        }

        private void Btnverisil_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=Lenovo-PC\SQLEXPRESS;Initial Catalog=OgrenciBilgileri;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from OgrenciBilgileri where ID=@ID";
            cmd.Parameters.AddWithValue("@ID", txtid.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("İşlem Başarılı.");
            }
            else
            {
                MessageBox.Show("İşlem Başarısız!!!");
            }
        }

        private void Btnveriekle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=Lenovo-PC\SQLEXPRESS;Initial Catalog=OgrenciBilgileri;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into OgrenciBilgileri(Ad, Soyad, TC, Sinif, Bolum, Okul) Values(@Ad, @Soyad, @TC, @Sinif, @Bolum, @Okul)";
            cmd.Parameters.AddWithValue("@Ad", txtad.Text);
            cmd.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@TC", txttc.Text);
            cmd.Parameters.AddWithValue("@Sinif", txtsinif.Text);
            cmd.Parameters.AddWithValue("@Bolum", txtbolum.Text);
            cmd.Parameters.AddWithValue("@Okul", txtokul.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("İşlem Başarılı.");
            }
            else
            {
                MessageBox.Show("İşlem Başarısız!!!");
            }

            foreach (Control item in grbx.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            lstbx.Items.Remove(lstbx.SelectedItem);
        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            lstbx.Items.Add(txtad.Text + " " + txtsoyad.Text + " " + txttc.Text + " " + txtsinif + " " + txtbolum.Text + " " + txtokul.Text);
            foreach (Control item in grbx.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
        }
    }
}
