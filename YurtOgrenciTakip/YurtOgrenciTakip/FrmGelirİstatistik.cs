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
    public partial class FrmGelirİstatistik : Form
    {
        public FrmGelirİstatistik()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        

        private void FrmGelirİstatistik_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutar
            SqlCommand komut = new SqlCommand("Select Sum(OdemeMiktar) from KasaBilgisi", bgl.baglantim());
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                labelpara.Text = oku[0].ToString();
            }
            bgl.baglantim().Close();

            //tekrarsız olarak ayları listeleme
            SqlCommand komut2 = new SqlCommand("Select distinct(OdemeAy)from KasaBilgisi", bgl.baglantim());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while(oku2.Read())
            {
                comboBoxAySeç.Items.Add(oku2[0].ToString());

            }
            bgl.baglantim().Close();

            //aylık kazanç veri çekme
            SqlCommand komut5 = new SqlCommand("select OdemeAy, sum(OdemeMiktar) from KasaBilgisi group by OdemeAy",bgl.baglantim());
            SqlDataReader oku3= komut5.ExecuteReader();
            while(oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);
            }
            bgl.baglantim().Close();
        
            


        }

        private void comboBoxAySeç_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum(OdemeMiktar) From KasaBilgisi where OdemeAy=@p1", bgl.baglantim());
            komut.Parameters.AddWithValue("@p1", comboBoxAySeç.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                label3.Text = oku[0].ToString();
            }
            bgl.baglantim().Close();
        }
    }
}
