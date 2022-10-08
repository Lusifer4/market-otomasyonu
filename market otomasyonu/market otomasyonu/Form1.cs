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
    public partial class FrmKullanici : Form
    {
        public FrmKullanici()
        {
            InitializeComponent();
        }
        //kullanici Girişi Ekranına Geçiş
       

      

        private void FrmKullanici_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmKullniciGiris frm = new FrmKullniciGiris();
            frm.ShowDialog();
            this.Hide();
            FrmPersonel perso = new FrmPersonel();
            perso.Kulanici = button1.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmKullniciGiris frm = new FrmKullniciGiris();
            frm.ShowDialog();
            this.Hide();
            FrmPersonel perso = new FrmPersonel();
            perso.Kulanici = button2.Text;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmKullniciGiris frm = new FrmKullniciGiris();
            frm.ShowDialog();
            this.Hide();
            
            
        }
    }
}
