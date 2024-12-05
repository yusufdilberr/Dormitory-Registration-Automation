using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOgrenciTakip
{
    public partial class FrmAçılışSayfası : Form
    {
        public FrmAçılışSayfası()
        {
            InitializeComponent();
        }

        private void FrmAçılışSayfası_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOgrenciTakipDataSet2.OgrenciBilgisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciBilgisiTableAdapter1.Fill(this.yurtOgrenciTakipDataSet2.OgrenciBilgisi);
            // TODO: Bu kod satırı 'yurtOgrenciTakipDataSet1.OgrenciBilgisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet1.OgrenciBilgisi);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text= DateTime.Now.ToLongTimeString();   
        }

        private void öğrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrKayıt frOgrKayıt = new FrmOgrKayıt();
            frOgrKayıt.Show();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciListesi frOgrList= new FrmOgrenciListesi();
            frOgrList.Show();
        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmOgrenciListesi frmOgrencilist2= new FrmOgrenciListesi();
            frmOgrencilist2.Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler frBolumEkle= new FrmBolumler();
            frBolumEkle.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler frBolumEkle = new FrmBolumler();
            frBolumEkle.Show();
        }

        private void öğrenciÖdemesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler frmOdemeler= new FrmOdemeler();
            frmOdemeler.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiderler frGiderEkle = new FormGiderler();
            frGiderEkle.Show();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderlerListesi frmGiderlerListesi= new FrmGiderlerListesi();
            frmGiderlerListesi.Show();
        }

        private void gelirİstatistiğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirİstatistik frGeliristatistik= new FrmGelirİstatistik();
            frGeliristatistik.Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminİşlemleri frAdminİşlemleri = new FrmAdminİşlemleri();
            frAdminİşlemleri.Show();
        }

        private void personelDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelDüzenleme frmPersonelDüzenleme = new FrmPersonelDüzenleme();
            frmPersonelDüzenleme.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void veriEklemeÇıkarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKamera frmqrkontrol = new FormKamera();
            frmqrkontrol.Show();
        }
    }
}
