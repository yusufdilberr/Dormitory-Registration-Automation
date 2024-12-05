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
using System.Net;
using System.Net.Mail;


namespace YurtOgrenciTakip
{
    public partial class FrmİlkEkran : Form
    {
        public FrmİlkEkran()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from YöneticiBilgisi where YöneticiAd=@p1 and YöneticiSifre=@p2", bgl.baglantim());
            komut.Parameters.AddWithValue("@p1", textBoxKullanıcıAD.Text);
            komut.Parameters.AddWithValue("@p2", textBoxŞifre.Text);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                FormMailDoğrulama frmmail = new FormMailDoğrulama();
                frmmail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre");
                textBoxKullanıcıAD.Clear();
                textBoxŞifre.Clear();
                textBoxKullanıcıAD.Focus();


            }
            bgl.baglantim().Close();
        }

        private void FrmAdminEkran_Load(object sender, EventArgs e)
        {
            

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
