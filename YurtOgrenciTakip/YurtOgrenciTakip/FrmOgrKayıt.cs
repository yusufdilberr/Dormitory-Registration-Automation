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
    public partial class FrmOgrKayıt : Form
    {
        public FrmOgrKayıt()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim()
        {

        };

        private void FrmOgrKayıt_Load(object sender, EventArgs e)
        {
            //Bolumleri listeleme kodları
            
            SqlCommand komut = new SqlCommand("Select BolumAd From BolumBilgisi", bgl.baglantim());

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBoxOgrBol.Items.Add(oku[0].ToString());
                

            }
            bgl.baglantim().Close();

            //Boş odaları listeleme kodları
            
            SqlCommand komut2 = new SqlCommand("Select OdaNo From OdaBilgisi where OdaKapasite != OdaAktif", bgl.baglantim());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBoxOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglantim().Close();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komutKaydet = new SqlCommand("insert into OgrenciBilgisi(OgrenciAd,OgrenciSoyad,OgrenciTcNo,OgrenciTelefon,OgrenciDogumTarihi,OgrenciBolüm,OgrenciMail,OgrenciOdaNo,OgrenciVeliAdSoyad,OgrenciVeliTelefon,OgrenciVeliAdres) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11)", bgl.baglantim());
                komutKaydet.Parameters.AddWithValue("@p1", txtOgrAd.Text);
                komutKaydet.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@p3", mskTxtTcNo.Text);
                komutKaydet.Parameters.AddWithValue("@p4", mskTxtTelNo.Text);
                komutKaydet.Parameters.AddWithValue("@p5", mskTxtDg.Text);
                komutKaydet.Parameters.AddWithValue("@p6", comboBoxOgrBol.Text);
                komutKaydet.Parameters.AddWithValue("@p7", txtOgrMail.Text);
                komutKaydet.Parameters.AddWithValue("@p8", comboBoxOdaNo.Text);
                komutKaydet.Parameters.AddWithValue("@p9", txtVeliAd.Text);
                komutKaydet.Parameters.AddWithValue("@p10", mskTxtVeliTel.Text);
                komutKaydet.Parameters.AddWithValue("@p11", richTextBoxAdres.Text);

                komutKaydet.ExecuteNonQuery();
                bgl.baglantim().Close();
                MessageBox.Show("Kaydınız Başarılı Bir Şekilde Yapıldı!");


                //ogrenci id yi labela çekme
                SqlCommand komutborc = new SqlCommand("select OgrenciID from OgrenciBilgisi",bgl.baglantim());
                SqlDataReader oku = komutborc.ExecuteReader();
                while(oku.Read())
                {
                    label12.Text = oku[0].ToString();

                }
                bgl.baglantim().Close();


                //ogrenci borç alanı oluşturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into BorcBilgisi (OgrenciID, OgrenciAd, OgrenciSoyad)values(@b1,@b2,@b3)", bgl.baglantim());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("b2", txtOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("b3", txtOgrSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglantim().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Sırasında Bir Hata Yaptınız!");
                throw;
            }

            //Öğrenci Oda Kontenjanı arttırma
            SqlCommand komutoda = new SqlCommand("update OdaBilgisi set OdaAktif=OdaAktif+1 where OdaNo=@oda1", bgl.baglantim());
            komutoda.Parameters.AddWithValue("@oda1", comboBoxOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglantim().Close();




        }
    }
}
