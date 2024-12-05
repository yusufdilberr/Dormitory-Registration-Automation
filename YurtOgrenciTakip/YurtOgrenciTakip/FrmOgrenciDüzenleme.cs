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
    public partial class FrmOgrenciDüzenleme : Form
    {
        public FrmOgrenciDüzenleme()
        {
            InitializeComponent();
        }
        public string id, ad, soyad, tc, telefon, dogum, bolum, odano, mail, veli, velitel, adres;

        private void buttonSil_Click(object sender, EventArgs e)
        {
            //öğrenci silme
            SqlCommand komutsil = new SqlCommand("delete from OgrenciBilgisi where OgrenciID=@k1", bgl.baglantim());
            komutsil.Parameters.AddWithValue("@k1", txtOgrenciID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglantim().Close();
            MessageBox.Show("Öğrenci Kaydı Silindi");

            //oda kontenjanı arttırma

            SqlCommand komutoda = new SqlCommand("update OdaBilgisi set OdaAktif=OdaAktif-1 where OdaNo=@oda", bgl.baglantim());
            komutoda.Parameters.AddWithValue("@oda", comboBoxOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglantim().Close();
            


        }

        SqlBaglantim bgl = new SqlBaglantim();
        
        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update OgrenciBilgisi set OgrenciAd=@p2, OgrenciSoyad=@p3, OgrenciTcNo=@p4, OgrenciTelefon=@p5,OgrenciDogumTarihi=@p6, OgrenciBolüm=@p7, OgrenciMail=@p8, OgrenciOdaNo=@p9, OgrenciVeliAdSoyad=@p10, OgrenciVeliTelefon=@p11, OgrenciVeliAdres=@p12 where OgrenciID=@p1 ", bgl.baglantim());
                komut.Parameters.AddWithValue("@p1", txtOgrenciID.Text);
                komut.Parameters.AddWithValue("@p2", txtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", mskTxtTcNo.Text);
                komut.Parameters.AddWithValue("@p5", mskTxtTelNo.Text);
                komut.Parameters.AddWithValue("@p6", mskTxtDg.Text);
                komut.Parameters.AddWithValue("@p7", comboBoxOgrBol.Text);
                komut.Parameters.AddWithValue("@p8", txtOgrMail.Text);
                komut.Parameters.AddWithValue("@p9", comboBoxOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", txtVeliAd.Text);
                komut.Parameters.AddWithValue("@p11", mskTxtVeliTel.Text);
                komut.Parameters.AddWithValue("@p12", richTextBoxAdres.Text);

                komut.ExecuteNonQuery();
                bgl.baglantim().Close();
                MessageBox.Show("Başarılı bir şekilde güncelleme işlemini gerçekleştirdiniz");

            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme işlemi sırasında bir hata yaptınız");
                throw;
            }
        }

        private void FrmOgrenciDüzenleme_Load(object sender, EventArgs e)
        {
            txtOgrenciID.Text = id;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            mskTxtTcNo.Text = tc;
            mskTxtTelNo.Text = telefon;
            mskTxtDg.Text= dogum;
            comboBoxOgrBol.Text = bolum;
            txtOgrMail.Text = mail;
            comboBoxOdaNo.Text = odano;
            txtVeliAd.Text = veli;
            mskTxtVeliTel.Text = velitel;
            richTextBoxAdres.Text = adres;





        }
    }
}
