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
    public partial class FrmPersonelEkleme : Form
    {
        public FrmPersonelEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5ANRQJA;Initial Catalog=market_otomasyon;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into personelTablo(tc,adsoyad,maas,tel,adres,mail)values(@tc,@adsoyad,@maas,@tel,@adres,@mail)", baglanti);
            komut.Parameters.AddWithValue("@tc", Convert.ToString(txttc.Text));
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@maas", Convert.ToString(txtMaas.Text));
            komut.Parameters.AddWithValue("@tel", Convert.ToString(txtTelefon.Text));
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@mail", txtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }
    }
}

