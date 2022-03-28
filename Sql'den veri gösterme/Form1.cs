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

namespace Sql_den_veri_gösterme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Listele()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=Lenovo-PC\SQLEXPRESS;Initial Catalog=OgrenciBilgileri;Integrated Security=True";
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select*from OgrenciBilgileri", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
