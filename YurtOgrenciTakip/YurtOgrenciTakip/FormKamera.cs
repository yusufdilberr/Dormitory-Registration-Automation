using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace YurtOgrenciTakip
{
    public partial class FormKamera : Form
    {
        public FormKamera()
        {
            InitializeComponent();
        }
        FilterInfoCollection fico;
        VideoCaptureDevice vcd;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormKamera_Load(object sender, EventArgs e)
        {
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo f in fico)
            {
                comboBox1.Items.Add(f.Name);
                comboBox1.SelectedIndex = 0;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fico[comboBox1.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();

                
        }

        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Image!=null)
            {
                BarcodeReader brd = new BarcodeReader();
                Result sonuc = brd.Decode((Bitmap)pictureBox1.Image);
                if(sonuc!=null)
                {
                    textBox1.Text = sonuc.ToString();
                    timer1.Stop();
                }
            }
            
        }
        string qrkod = "yusufadmin123456";
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == qrkod)
                {
                AdminPaneliDağılım adminpanel = new AdminPaneliDağılım();
                adminpanel.Show();
                this.Hide();
                }

                

            
        }
    }
}
