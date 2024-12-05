namespace YurtOgrenciTakip
{
    partial class FrmOgrKayıt
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayıt));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.mskTxtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtTelNo = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtDg = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxOgrBol = new System.Windows.Forms.ComboBox();
            this.txtOgrMail = new System.Windows.Forms.TextBox();
            this.comboBoxOdaNo = new System.Windows.Forms.ComboBox();
            this.txtVeliAd = new System.Windows.Forms.TextBox();
            this.mskTxtVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.richTextBoxAdres = new System.Windows.Forms.RichTextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(58, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "TC Kimlik NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(68, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon NO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(56, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(45, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Öğrenci Bölümü:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(62, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Öğrenci Mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(88, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Oda NO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(54, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Veli Ad Soyad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(47, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Veli Telefon No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(101, 562);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Adres:";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrAd.Location = new System.Drawing.Point(175, 46);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(255, 24);
            this.txtOgrAd.TabIndex = 11;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrSoyad.Location = new System.Drawing.Point(175, 91);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(255, 24);
            this.txtOgrSoyad.TabIndex = 12;
            // 
            // mskTxtTcNo
            // 
            this.mskTxtTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTxtTcNo.Location = new System.Drawing.Point(175, 138);
            this.mskTxtTcNo.Mask = "00000000000";
            this.mskTxtTcNo.Name = "mskTxtTcNo";
            this.mskTxtTcNo.Size = new System.Drawing.Size(255, 24);
            this.mskTxtTcNo.TabIndex = 13;
            // 
            // mskTxtTelNo
            // 
            this.mskTxtTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTxtTelNo.Location = new System.Drawing.Point(175, 184);
            this.mskTxtTelNo.Mask = "(999) 000-0000";
            this.mskTxtTelNo.Name = "mskTxtTelNo";
            this.mskTxtTelNo.Size = new System.Drawing.Size(255, 24);
            this.mskTxtTelNo.TabIndex = 14;
            // 
            // mskTxtDg
            // 
            this.mskTxtDg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTxtDg.Location = new System.Drawing.Point(175, 232);
            this.mskTxtDg.Mask = "00/00/0000";
            this.mskTxtDg.Name = "mskTxtDg";
            this.mskTxtDg.Size = new System.Drawing.Size(255, 24);
            this.mskTxtDg.TabIndex = 15;
            this.mskTxtDg.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxOgrBol
            // 
            this.comboBoxOgrBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxOgrBol.FormattingEnabled = true;
            this.comboBoxOgrBol.Location = new System.Drawing.Point(175, 286);
            this.comboBoxOgrBol.Name = "comboBoxOgrBol";
            this.comboBoxOgrBol.Size = new System.Drawing.Size(255, 26);
            this.comboBoxOgrBol.TabIndex = 16;
            // 
            // txtOgrMail
            // 
            this.txtOgrMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrMail.Location = new System.Drawing.Point(175, 338);
            this.txtOgrMail.Name = "txtOgrMail";
            this.txtOgrMail.Size = new System.Drawing.Size(255, 24);
            this.txtOgrMail.TabIndex = 17;
            // 
            // comboBoxOdaNo
            // 
            this.comboBoxOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxOdaNo.FormattingEnabled = true;
            this.comboBoxOdaNo.Location = new System.Drawing.Point(175, 399);
            this.comboBoxOdaNo.Name = "comboBoxOdaNo";
            this.comboBoxOdaNo.Size = new System.Drawing.Size(255, 26);
            this.comboBoxOdaNo.TabIndex = 18;
            // 
            // txtVeliAd
            // 
            this.txtVeliAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeliAd.Location = new System.Drawing.Point(175, 452);
            this.txtVeliAd.Name = "txtVeliAd";
            this.txtVeliAd.Size = new System.Drawing.Size(255, 24);
            this.txtVeliAd.TabIndex = 19;
            // 
            // mskTxtVeliTel
            // 
            this.mskTxtVeliTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTxtVeliTel.Location = new System.Drawing.Point(175, 499);
            this.mskTxtVeliTel.Mask = "(999) 000-0000";
            this.mskTxtVeliTel.Name = "mskTxtVeliTel";
            this.mskTxtVeliTel.Size = new System.Drawing.Size(255, 24);
            this.mskTxtVeliTel.TabIndex = 20;
            // 
            // richTextBoxAdres
            // 
            this.richTextBoxAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxAdres.Location = new System.Drawing.Point(175, 547);
            this.richTextBoxAdres.Name = "richTextBoxAdres";
            this.richTextBoxAdres.Size = new System.Drawing.Size(255, 134);
            this.richTextBoxAdres.TabIndex = 21;
            this.richTextBoxAdres.Text = "";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(299, 706);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(131, 40);
            this.buttonKaydet.TabIndex = 22;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 579);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // FrmOgrKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 758);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.richTextBoxAdres);
            this.Controls.Add(this.mskTxtVeliTel);
            this.Controls.Add(this.txtVeliAd);
            this.Controls.Add(this.comboBoxOdaNo);
            this.Controls.Add(this.txtOgrMail);
            this.Controls.Add(this.comboBoxOgrBol);
            this.Controls.Add(this.mskTxtDg);
            this.Controls.Add(this.mskTxtTelNo);
            this.Controls.Add(this.mskTxtTcNo);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOgrKayıt";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmOgrKayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.MaskedTextBox mskTxtTcNo;
        private System.Windows.Forms.MaskedTextBox mskTxtTelNo;
        private System.Windows.Forms.MaskedTextBox mskTxtDg;
        private System.Windows.Forms.ComboBox comboBoxOgrBol;
        private System.Windows.Forms.TextBox txtOgrMail;
        private System.Windows.Forms.ComboBox comboBoxOdaNo;
        private System.Windows.Forms.TextBox txtVeliAd;
        private System.Windows.Forms.MaskedTextBox mskTxtVeliTel;
        private System.Windows.Forms.RichTextBox richTextBoxAdres;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label label12;
    }
}

