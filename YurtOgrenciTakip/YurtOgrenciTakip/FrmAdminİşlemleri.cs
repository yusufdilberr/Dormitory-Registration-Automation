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
    public partial class FrmAdminİşlemleri : Form
    {
        public FrmAdminİşlemleri()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmAdminİşlemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOgrenciTakipDataSet6.YöneticiBilgisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yöneticiBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet6.YöneticiBilgisi);

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("insert into YöneticiBilgisi(YöneticiAd,YöneticiSifre)values(@p1,@p2)",bgl.baglantim());
            komut.Parameters.AddWithValue("@p1",textBoxAdminNick.Text);
            komut.Parameters.AddWithValue("@p2", textBoxAdminŞifre.Text);
            bgl.baglantim().Close();
            komut.ExecuteNonQuery();
            MessageBox.Show("Yönetici eklendi!");
            this.yöneticiBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet6.YöneticiBilgisi);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen ;
            seçilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, şifre, id;
            id = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            şifre = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();

            textBoxAdminNick.Text = ad;
            textBoxAdminID.Text = id;
            textBoxAdminŞifre.Text = şifre;

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from YöneticiBilgisi where YöneticiID=@p1",bgl.baglantim());
            komut.Parameters.AddWithValue("@p1",textBoxAdminID.Text);
            komut.ExecuteNonQuery();
            bgl.baglantim().Close();
            MessageBox.Show("Admin silme işlemi başarıyla gerçekleşti");
            this.yöneticiBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet6.YöneticiBilgisi);

        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update YöneticiBilgisi set YöneticiAd=@p1,YöneticiSifre=@p2 where YöneticiID=@p3", bgl.baglantim());
            komut3.Parameters.AddWithValue("@p1",textBoxAdminNick.Text);
            komut3.Parameters.AddWithValue("@p2", textBoxAdminŞifre.Text);
            komut3.Parameters.AddWithValue("@p3", textBoxAdminID.Text);
            komut3.ExecuteNonQuery();
            bgl.baglantim().Close();
            MessageBox.Show("Admin güncelleme işlemi başarıyla gerçekleştirildi");
            this.yöneticiBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet6.YöneticiBilgisi);

        }
    }
}
