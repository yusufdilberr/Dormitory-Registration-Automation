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
    public partial class FrmGiderGüncelleme : Form
    {
        public FrmGiderGüncelleme()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl= new SqlBaglantim();
        public string elektrik, su, dogalgaz, gıda, diger, internet, personel, id;

        private void buttonGiderKayıt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update GiderlerBilgisi set ElektrikGideri=@p1, SuGideri=@p2, DogalgazGideri=@p3, InternetGideri=@p4, GıdaGideri=@p5, PersonelGideri=@p6, DigerGiderler=@p7 where OdemeID=@p8", bgl.baglantim());
                komut.Parameters.AddWithValue("@p8", txtGiderID.Text);
                komut.Parameters.AddWithValue("@p1", txtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtSu.Text);
                komut.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtİnternet.Text);
                komut.Parameters.AddWithValue("@p5", txtGıda.Text);
                komut.Parameters.AddWithValue("@p6", txtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtDiğer.Text);

                komut.ExecuteNonQuery();
                bgl.baglantim().Close();
                MessageBox.Show("Başarılı bir şekilde gider güncellemesi yapıldı.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı bir güncelleme yaptınız.");
                throw;
            }
        }

        private void FrmGiderGüncelleme_Load(object sender, EventArgs e)
        {
            txtGiderID.Text = id;
            txtElektrik.Text = elektrik;
            txtSu.Text = su;
            txtDogalgaz.Text = dogalgaz;
            txtGıda.Text = gıda;
            txtDiğer.Text = diger;
            txtİnternet.Text = internet;
            txtPersonel.Text = personel;
            
        }
    }
}
