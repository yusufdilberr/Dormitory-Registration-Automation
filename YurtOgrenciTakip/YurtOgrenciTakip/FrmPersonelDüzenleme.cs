using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace YurtOgrenciTakip
{
    public partial class FrmPersonelDüzenleme : Form
    {
        public FrmPersonelDüzenleme()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmPersonelDüzenleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOgrenciTakipDataSet7.PersonelBilgisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet7.PersonelBilgisi);
            SqlCommand komut = new SqlCommand("Select PersonelDepartman From PersonelBilgisi", bgl.baglantim());

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBoxPersDep.Items.Add(oku[0].ToString());


            }
            bgl.baglantim().Close();
        }

        private void buttonKayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into PersonelBilgisi(PersonelAdSoyad,PersonelDepartman)values(@p1,@p2)", bgl.baglantim());
            komut2.Parameters.AddWithValue("@p1", textBoxPersAd.Text);
            komut2.Parameters.AddWithValue("@p2", comboBoxPersDep.Text);
            komut2.ExecuteNonQuery();
            bgl.baglantim().Close();
            MessageBox.Show("Kayıt Eklendi.");
            this.personelBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet7.PersonelBilgisi);


        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("delete from PersonelBilgisi where PersonelID=@p1", bgl.baglantim());
            komut3.Parameters.AddWithValue("@p1",textBoxPersID.Text);
            komut3.ExecuteNonQuery();

            MessageBox.Show("Başarıyla silme işlemi gerçekleştirildi");
            bgl.baglantim().Close();
            this.personelBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet7.PersonelBilgisi);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen;
            seçilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, departman, id;
            id = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
             departman = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();

            textBoxPersAd.Text = ad;
            comboBoxPersDep.Text = departman;
            textBoxPersID.Text = id;    
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut5= new SqlCommand("update PersonelBilgisi set PersonelAdSoyad=@p1,PersonelDepartman=@p2 where PersonelID=@p3",bgl.baglantim());  
            komut5.Parameters.AddWithValue("@p1",textBoxPersAd.Text);
            komut5.Parameters.AddWithValue("@p2", comboBoxPersDep.Text);
            komut5.Parameters.AddWithValue("@p3", textBoxPersID.Text);

            komut5.ExecuteNonQuery();
            bgl.baglantim().Close();
            MessageBox.Show("Kayıt Güncellendi");
            this.personelBilgisiTableAdapter.Fill(this.yurtOgrenciTakipDataSet7.PersonelBilgisi);



        }
    }
}
