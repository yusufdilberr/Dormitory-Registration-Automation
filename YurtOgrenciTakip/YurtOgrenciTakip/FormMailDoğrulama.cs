using System;
using System.Net.Mail;
using System.Windows.Forms;
using System.Net;

namespace YurtOgrenciTakip
{
    public partial class FormMailDoğrulama : Form
    {
        public FormMailDoğrulama()
        {
            InitializeComponent();
        }
        Random rnd= new Random();
        string onayKodu;
        
        private void button1_Click(object sender, EventArgs e)
        {
            onayKodu=rnd.Next(9999).ToString();
            MailMessage sms= new MailMessage(textBox1.Text,"gamenews61@gmail.com","GÜVENLİK KODU","güvenlik kodunuz"+onayKodu);
            SmtpClient smtpclient = new SmtpClient("smtp.office365.com",587);
            smtpclient.EnableSsl = true;
            smtpclient.Credentials = new NetworkCredential(textBox1.Text, textBox2.Text);
            //smtpclient.Send(sms);
            MessageBox.Show("Kod Gönderildi");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox3.Text==onayKodu)
            {

                MessageBox.Show("Doğru Kodu Girdiniz");
                FrmAçılışSayfası frmanasayfa = new FrmAçılışSayfası();
                frmanasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kod girdiniz lütfen tekrar deneyin");
            }
        }
    }
}
