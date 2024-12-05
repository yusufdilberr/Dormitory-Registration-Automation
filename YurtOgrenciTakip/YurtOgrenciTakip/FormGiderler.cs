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
    public partial class FormGiderler : Form
    {
        public FormGiderler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void buttonGiderKayıt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into GiderlerBilgisi (ElektrikGideri,SuGideri,DogalgazGideri,InternetGideri,GıdaGideri,PersonelGideri,DigerGiderler)Values(@p1, @p2, @p3, @p4, @p5, @p6, @p7)", bgl.baglantim());
                komut.Parameters.AddWithValue("@p1", txtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtSu.Text);
                komut.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtİnternet.Text);
                komut.Parameters.AddWithValue("@p5", txtGıda.Text);
                komut.Parameters.AddWithValue("@p6", txtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtDiğer.Text);

                komut.ExecuteNonQuery();
                bgl.baglantim().Close();
                MessageBox.Show("Başarılı bir şekilde giderler kaydedildi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı bir kayıt yaptınız");
                throw;
            }
        }
    }
}
