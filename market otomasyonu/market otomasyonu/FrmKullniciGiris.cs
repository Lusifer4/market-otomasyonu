using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_otomasyonu
{
    public partial class FrmKullniciGiris : Form
    {
        
        
        public FrmKullniciGiris()
        {
            InitializeComponent();
        }

        private void FrmKullniciGiris_Load(object sender, EventArgs e)
        {

        }
       
           
        public void button1_Click(object sender, EventArgs e)
        {
       string Kullanici;
        string sifre;
            

           Kullanici = TextBox1.Text;
           sifre = TextBox2.Text;
          



            if (Kullanici == "Müdür" && sifre == "4545")
            {

                this.Hide();
                
                FrmMüdür frM = new FrmMüdür();
                frM.ShowDialog();
               

            }

            else if (Kullanici == "MüdürYardımcısı" && sifre == "4545")
            {

                this.Hide();
                FrmYardimci frMY = new FrmYardimci();
                frMY.ShowDialog();
                

            }

            else if (Kullanici == "Personel" && sifre == "4545")
            {

                this.Hide();
                FrmPersonel frP = new FrmPersonel();
                
                frP.Kulanici = Kullanici;
                frP.ShowDialog();

            }


            else


            {

                {
                    MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre", "HATA");

                }
            }
        }
    }
    }

