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
    public partial class FrmGiderlerListesi : Form
    {
        public FrmGiderlerListesi()
        {
            InitializeComponent();
        }

        private void FrmGiderlerListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOgrenciTakipDataSet5.GiderlerBilgisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet5.GiderlerBilgisi);

        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen;

            FrmGiderGüncelleme frgg=new FrmGiderGüncelleme();
            seçilen = dataGridView1.SelectedCells[0].RowIndex;
            frgg.id = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            frgg.elektrik = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            frgg.su = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            frgg.dogalgaz = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            frgg.internet = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            frgg.gıda = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
            frgg.personel = dataGridView1.Rows[seçilen].Cells[6].Value.ToString();
            frgg.diger = dataGridView1.Rows[seçilen].Cells[7].Value.ToString();

            frgg.Show();
        }
    }
}
