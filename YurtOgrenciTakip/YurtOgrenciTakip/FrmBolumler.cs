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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

         SqlBaglantim bgl = new SqlBaglantim();

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOgrenciTakipDataSet.BolumBilgisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet.BolumBilgisi);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komutsil = new SqlCommand("delete from BolumBilgisi where BolumID=@p1", bgl.baglantim());
                komutsil.Parameters.AddWithValue("@p1", TxtBolumID.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglantim().Close();
                MessageBox.Show("Silme işlemi başarılı bir şekilde gerçekleşti");
                this.bolumBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet.BolumBilgisi);
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı bir silme işlemi gerçekleştirdiniz!");
                throw;
            }
        }

        private void pictureBoxBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komutekle = new SqlCommand("insert into BolumBilgisi (BolumAd) values (@p1)", bgl.baglantim());
                komutekle.Parameters.AddWithValue("@p1", txtBolumAdı.Text);
                komutekle.ExecuteNonQuery();
                bgl.baglantim().Close();
                MessageBox.Show("Bölüm Başarıyla Eklendi");
                this.bolumBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet.BolumBilgisi);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Bir Giriş Yaptınız!");

                throw;
            }


        }
        int seçilen;
       
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolümAd;
            seçilen = dataGridView2.SelectedCells[0].RowIndex;
            id = dataGridView2.Rows[seçilen].Cells[0].Value.ToString();
            bolümAd= dataGridView2.Rows[seçilen].Cells[1].Value.ToString();

            txtBolumAdı.Text = bolümAd;
            TxtBolumID.Text = id;
            
            
        }

        private void pictureBoxBolumGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komutgüncelle = new SqlCommand("update BolumBilgisi Set BolumAd=@p1 where BolumID=@p2", bgl.baglantim());
                komutgüncelle.Parameters.AddWithValue("@p2", TxtBolumID.Text);
                komutgüncelle.Parameters.AddWithValue("@p1", txtBolumAdı.Text);
                komutgüncelle.ExecuteNonQuery();
                bgl.baglantim().Close();
                MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti.");
                this.bolumBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet.BolumBilgisi);
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı bir güncelleme işlemi gerçekleştirdiniz.");

                throw;
            }
        }
    }
}
