using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;


namespace YurtOgrenciTakip
{
    public partial class FormQrKod : Form
    {
        public FormQrKod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc= new QRCodeEncoder();
            pictureBox1.Image = enc.Encode(textBox1.Text);
        }
    }
}
