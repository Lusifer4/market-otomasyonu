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
    public partial class FrmYardimci : Form
    {
        public FrmYardimci()
        {
            InitializeComponent();
        }

        private void btnPers_Click(object sender, EventArgs e)//personel listesi formu
        {
            frmPersListe2 frmPerLis = new frmPersListe2();
            frmPerLis.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)//Ürün ekleme formu
        {
            FrmUrunEkle frmUrEk = new FrmUrunEkle();
            frmUrEk.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)//ürün listele formu
        {
            FrmPersonelListe frmUrLis = new FrmPersonelListe();
            frmUrLis.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmPersonel pers = new FrmPersonel();
            pers.Kulanici = lblMüdür.Text;
            pers.ShowDialog();
        }
    }
}
