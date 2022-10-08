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
    public partial class FrmUrunListe : Form
    {
        public FrmUrunListe()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5ANRQJA;Initial Catalog=market_otomasyon;Integrated Security=True");
        DataSet daset = new DataSet();

        private void FrmUrunListe_Load(object sender, EventArgs e)
        {
            Kayit_Göster();
        }
        private void Kayit_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urunTablo", baglanti);
            adtr.Fill(daset, "urunTablo");
            dataGridView1.DataSource = daset.Tables["urunTablo"];
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urunTablo where id='" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urunTablo"].Clear();
            Kayit_Göster();
            MessageBox.Show("Ürün Silindi");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from urunTablo where id like '%" + txtidara.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            txturunad.Text = dataGridView1.CurrentRow.Cells["urunadı"].Value.ToString();
            txtmiktar.Text = dataGridView1.CurrentRow.Cells["Urunmiktarı"].Value.ToString();
            txtfiyat.Text = dataGridView1.CurrentRow.Cells["urunfiyatı"].Value.ToString();
            txtkatagori.Text = dataGridView1.CurrentRow.Cells["katagori"].Value.ToString();
          
        }
    }
}
