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
    public partial class FrmPersonel : Form
    {
        public string Kulanici;
        public FrmPersonel()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5ANRQJA;Initial Catalog=market_otomasyon;Integrated Security=True");
        DataSet daset = new DataSet();


        public void sqlSelect(Button s)//data grid de buttona göre katalog geliyor
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from urunTablo where katagori  like '%" + s.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        public void hesap(decimal sayi)//kdv miktar hesaplama
        {
            decimal i, u, b, z, c, d, w;
            i = decimal.Parse(txtfiyati.Text);
            u = decimal.Parse(txtmiktari.Text);
            z = decimal.Parse(lblSepetParası.Text);
            b = i / 100 * sayi;
            c = b + i;
            d = c * u;
            w = z + d;
            lblSepetParası.Text = w.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//meyve buttonu
        {

            sqlSelect(btnmeyve);
        }

        private void btnsebze_Click(object sender, EventArgs e)//sebze buttonu
        {

            sqlSelect(btnsebze);
        }

        private void btnabur_Click(object sender, EventArgs e)//abur cubur butonu
        {

            sqlSelect(btnabur);
        }

        private void btntemizlik_Click(object sender, EventArgs e)//temizlik buttonu
        {


            sqlSelect(btntemizlik);
        }

        private void btnçerez_Click(object sender, EventArgs e)// çerez butonu
        {

            sqlSelect(btnçerez);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//text boxlara veriyi iletme
        {
            txtadi.Text = dataGridView1.CurrentRow.Cells["urunadı"].Value.ToString();
            txtfiyati.Text = dataGridView1.CurrentRow.Cells["urunfiyatı"].Value.ToString();
            txtkatagori.Text = dataGridView1.CurrentRow.Cells["katagori"].Value.ToString();
        }

        private void miktarolay(object sender, EventArgs e)//Ürün Miktarı
        {
            Button btn = (Button)sender;
            txtmiktari.Text = btn.Text;
        }

        private void paraOlay(object sender, EventArgs e)//para
        {
            decimal i, b, c;
            Button btn = (Button)sender;

            i = decimal.Parse(btn.Text); b = decimal.Parse(OdenenLabel.Text);
            c = i + b;
            OdenenLabel.Text = c.ToString();
        }

        private void btnsepetekle_Click(object sender, EventArgs e)//sepeti temizle butonu
        {
            txtsepet.Clear();
            lblSepetParası.Text = "00,00";
            OdenenLabel.Text = "00,00";
            lblparaust.Text = "00,00";
            txtindirim.Text = "";
        }

        private void btnekle_Click(object sender, EventArgs e)//sepete ekle
        {

            txtsepet.Text += txtmiktari.Text + "\t\t";
            txtsepet.Text += txtadi.Text + "\t\t";




            if (txtkatagori.Text == "Meyve")
            {
                /*
                decimal i,u,b,z,c,d,w;
                i = decimal.Parse(txtfiyati.Text);
                u = decimal.Parse(txtmiktari.Text);
                z = decimal.Parse(lblSepetParası.Text);
                b = i /100*2;
                c=b + i;
                d=c * u;
                w=z + d;
                lblSepetParası.Text = w.ToString();*/

                hesap(2);

            }
            else if (txtkatagori.Text == "Sebze")
            {
                /*
                decimal i, u, b, z, c, d, w
                i = decimal.Parse(txtfiyati.Text);
                u = decimal.Parse(txtmiktari.Text);
                z = decimal.Parse(lblSepetParası.Text);
                b = i / 100 * 3;
                c = b + i;
                d = c * u;
                w = z + d;
                lblSepetParası.Text = w.ToString();*/
                hesap(3);

            }
            else if (txtkatagori.Text == "Abur Cubur")
            {

                /*decimal i, u, b, z, c, d, w;

                i = decimal.Parse(txtfiyati.Text);
                u = decimal.Parse(txtmiktari.Text);
                z = decimal.Parse(lblSepetParası.Text);
                b = i / 100 * 4;
                c = b + i;
                d = c * u;
                w = z + d;
                lblSepetParası.Text = w.ToString();*/
                hesap(4);

            }
            else if (txtkatagori.Text == "Temizlik Ürünleri")
            {

                /* decimal i, u, b, z, c, d, w;
                 i = decimal.Parse(txtfiyati.Text);
                 u = decimal.Parse(txtmiktari.Text);
                 z = decimal.Parse(lblSepetParası.Text);
                 b = i / 100 * 5;
                 c = b + i;
                 d = c * u;
                 w = z + d;
                 lblSepetParası.Text = w.ToString();*/
                hesap(5);

            }
            else if (txtkatagori.Text == "Çerez")
            {
                /*
                decimal i, u, b, z, c, d, w;
                i = decimal.Parse(txtfiyati.Text);
                u = decimal.Parse(txtmiktari.Text);
                z = decimal.Parse(lblSepetParası.Text);
                b = i / 100 * 6;
                c = b + i;
                d = c * u;
                w = z + d;
                lblSepetParası.Text = w.ToString();*/

                hesap(6);

            }
            txtmiktari.Text = "1";

            txtadi.Clear();
            txtfiyati.Clear();
            txtkatagori.Clear();

        }

        private void btnfiş_Click(object sender, EventArgs e)//fiş yazdırma
        {
            
            decimal o, s, t;
            o = decimal.Parse(OdenenLabel.Text);
            s = decimal.Parse(lblSepetParası.Text);
             
            if (s>=500 && s<=750)
            {
                s=s-(s*5/100);
            }
            else if (s>=751&&s<=1000)
            {
                s=s-(s*10/100);
            }
            else if (s>=1001)
            {
                s = s - (s * 15 / 100);
            }
            t=o-s ;
             lblparaust.Text = t.ToString();
         }   
            
      

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            txtkullanici.Text = Kulanici;
            if (txtkullanici.Text == "Personel")
            {
                txtindirim.Enabled = false;
                btnindirim.Enabled = false;
            }
        }

        private void btnindirim_Click(object sender, EventArgs e)//indirim işlemleri
        {
            if (txtkullanici.Text == "Müdür")
            {
                decimal i = 0;
                i = decimal.Parse(txtindirim.Text);

                if (i <= 100 && i > 0)
                {
                    decimal s = 0, t = 0;
                    s = decimal.Parse(lblSepetParası.Text);
                    t = s - (s * i / 100);
                    lblSepetParası.Text = t.ToString();

                }
                else
                {
                    MessageBox.Show("İndirim Geçersiz");
                }
            }
            else if (txtkullanici.Text == "Müdür Yardımcısı")
            {
                decimal i = 0;
                i = decimal.Parse(txtindirim.Text);

                if (i <= 20 && i > 0)
                {
                    decimal s = 0, t = 0;
                    s = decimal.Parse(lblSepetParası.Text);
                    t = s - (s * i / 100);
                    lblSepetParası.Text = t.ToString();

                }
                else
                {
                    MessageBox.Show("İndirim Geçersiz");
                }

            }
            
        }
        }
    }

