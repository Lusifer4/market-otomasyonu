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

namespace market_otomasyonu
{
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5ANRQJA;Initial Catalog=market_otomasyon;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into urunTablo(urunadı,Urunmiktarı,urunfiyatı,katagori)values(@urunadı,@Urunmiktarı,@urunfiyatı,@katagori)", baglanti);
            komut.Parameters.AddWithValue("@urunadı", txturunadi.Text);
            komut.Parameters.AddWithValue("@Urunmiktarı", txtmiktar.Text);
            komut.Parameters.AddWithValue("@urunfiyatı", txtfiyat.Text);
            komut.Parameters.AddWithValue("@katagori", comboBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Eklendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

