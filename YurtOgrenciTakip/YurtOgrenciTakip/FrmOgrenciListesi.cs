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
    public partial class FrmOgrenciListesi : Form
    {
        public FrmOgrenciListesi()
        {
            InitializeComponent();
        }

        private void FrmOgrenciListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOgrenciTakipDataSet4.OgrenciBilgisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet4.OgrenciBilgisi);

        }
        int seçilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seçilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrenciDüzenleme fr= new FrmOgrenciDüzenleme();
            fr.id = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            fr.tc = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            fr.telefon = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            fr.dogum = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
            fr.bolum = dataGridView1.Rows[seçilen].Cells[6].Value.ToString();
            fr.mail = dataGridView1.Rows[seçilen].Cells[7].Value.ToString();
            fr.odano = dataGridView1.Rows[seçilen].Cells[8].Value.ToString();
            fr.veli = dataGridView1.Rows[seçilen].Cells[9].Value.ToString();
            fr.velitel = dataGridView1.Rows[seçilen].Cells[10].Value.ToString();
            fr.adres = dataGridView1.Rows[seçilen].Cells[11].Value.ToString();
            fr.Show();

        }
    }
}
