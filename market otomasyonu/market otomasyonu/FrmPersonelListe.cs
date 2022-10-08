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
    public partial class FrmPersonelListe : Form
    {
        public FrmPersonelListe()
        {
            InitializeComponent();
        }
         SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5ANRQJA;Initial Catalog=market_otomasyon;Integrated Security=True");
         DataSet daset = new DataSet();

        
        
        private void FrmPersonelListe_Load(object sender, EventArgs e)
        {
            Kayit_Göster();          
        }

        private void Kayit_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from personelTablo", baglanti);
            adtr.Fill(daset, "personelTablo");
            dataGridView1.DataSource = daset.Tables["personelTablo"];
            baglanti.Close();
        }

        
        private void btnGuncelle_Click(object sender, EventArgs e)//Güncele Buttonu
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update personelTablo set adsoyad=@adsoyad,maas=@maas,tel=@tel,adres=@adres,mail=@mail where tc =@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", Convert.ToString(txttc.Text));
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@maas", Convert.ToString(txtMaas.Text));
            komut.Parameters.AddWithValue("@tel", Convert.ToString(txtTelefon.Text));
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@mail", txtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["personelTablo"].Clear();
            Kayit_Göster();
            MessageBox.Show("Personel Bilgileri Güncellendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)//İşten Çıkarma Butonnu
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from personelTablo where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["personelTablo"].Clear();
            Kayit_Göster();
            MessageBox.Show("Personel İşten Çıkarıldı");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)//Tc Arama Texti
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from personelTablo where tc like '%" + txtTcAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//gride tıklayınca veri kuttulara gidiyo
        {
            txttc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtMaas.Text = dataGridView1.CurrentRow.Cells["maas"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["tel"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells["mail"].Value.ToString();
        }
    }
}
