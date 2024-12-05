using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtOgrenciTakip
{
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOgrenciTakipDataSet3.BorcBilgisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borcBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet3.BorcBilgisi);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen;
            string id, ad, soyad, kalan;

            seçilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();

            txtOgrenciAd.Text = ad;
            txtOgrenciSoyad.Text = soyad;
            txtOgrenciKalan.Text=kalan;
            txtOgrenciID.Text = id;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ödenen tutarı kalan tutardan düşme
            int ödenen, kalan, yeniborç;
           ödenen=Convert.ToInt16(txtOgrenciOdenen.Text);
            kalan = Convert.ToInt16(txtOgrenciKalan.Text);

            yeniborç = kalan - ödenen;
            txtOgrenciKalan.Text = yeniborç.ToString();

            //yeni tutarı veri tabanına kaydetme
            SqlCommand komut = new SqlCommand("update BorcBilgisi set OgrenciKalanBorc=@p1 where OgrenciID=@p2",bgl.baglantim());
            komut.Parameters.AddWithValue("@p2", txtOgrenciID.Text);
            komut.Parameters.AddWithValue("@p1", txtOgrenciKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglantim().Close();

            MessageBox.Show("Başarıyla Ödeme Yapıldı.");
            this.borcBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet3.BorcBilgisi);

            //Kasa tablosuna ekleme yapma

            SqlCommand komut2 = new SqlCommand("insert into KasaBilgisi(OdemeAy,OdemeMiktar)values(@k1,@k2)", bgl.baglantim());
            komut2.Parameters.AddWithValue("@k1", txtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", txtOgrenciOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglantim().Close();
        }
    }
}
