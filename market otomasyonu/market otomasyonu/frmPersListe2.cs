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
    public partial class frmPersListe2 : Form
    {
        public frmPersListe2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5ANRQJA;Initial Catalog=market_otomasyon;Integrated Security=True");
        DataSet daset = new DataSet();
        private void frmPersListe2_Load(object sender, EventArgs e)
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

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txttc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtMaas.Text = dataGridView1.CurrentRow.Cells["maas"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["tel"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells["mail"].Value.ToString();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from personelTablo where tc like '%" + txtTcAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
