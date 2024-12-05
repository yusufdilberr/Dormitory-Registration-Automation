using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOgrenciTakip
{
    public partial class AdminPaneliDağılım : Form
    {
        public AdminPaneliDağılım()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPersonelDüzenleme frmpersonel = new FrmPersonelDüzenleme();
            frmpersonel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAdminİşlemleri frmAdmin = new FrmAdminİşlemleri();
            frmAdmin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormGiderler frmg = new FormGiderler();
            frmg.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmOdemeler frmpara = new FrmOdemeler();
            frmpara.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOgrenciListesi frmlist = new FrmOgrenciListesi();
            frmlist.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormQrKod frmqr= new FormQrKod();
            frmqr.Show();
        }
    }
}
