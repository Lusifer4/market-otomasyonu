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
    public partial class FrmMüdür : Form
    {
        public FrmMüdür()
        {
            InitializeComponent();
        }

        private void btnPersEk_Click(object sender, EventArgs e)//personel ekleme formu
        {
            FrmPersonelEkleme frmP = new FrmPersonelEkleme();
            frmP.ShowDialog();
        }

        private void btnPers_Click(object sender, EventArgs e)//personel listeleme formu
        {
            FrmPersonelListe frmPerLis = new FrmPersonelListe();
            frmPerLis.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)//ürün ekleme gormu
        {
            FrmUrunEkle frmUrEk = new FrmUrunEkle();
            frmUrEk.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)//ürün listeleme Formu
        {
            FrmUrunListe frmUrLis = new FrmUrunListe();
            frmUrLis.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmPersonel pers = new FrmPersonel();
            pers.Kulanici = lblMüdür.Text;
            pers.ShowDialog();

        }

        private void FrmMüdür_Load(object sender, EventArgs e)
        {
           
        }
    }
}
