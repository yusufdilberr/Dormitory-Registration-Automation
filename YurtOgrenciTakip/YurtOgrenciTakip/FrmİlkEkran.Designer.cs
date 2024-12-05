namespace YurtOgrenciTakip
{
    partial class FrmİlkEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmİlkEkran));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxKullanıcıAD = new System.Windows.Forms.TextBox();
            this.textBoxŞifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(124, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Ad:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxKullanıcıAD
            // 
            this.textBoxKullanıcıAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKullanıcıAD.Location = new System.Drawing.Point(293, 76);
            this.textBoxKullanıcıAD.Name = "textBoxKullanıcıAD";
            this.textBoxKullanıcıAD.Size = new System.Drawing.Size(192, 34);
            this.textBoxKullanıcıAD.TabIndex = 2;
            // 
            // textBoxŞifre
            // 
            this.textBoxŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxŞifre.Location = new System.Drawing.Point(293, 123);
            this.textBoxŞifre.Name = "textBoxŞifre";
            this.textBoxŞifre.Size = new System.Drawing.Size(192, 34);
            this.textBoxŞifre.TabIndex = 4;
            this.textBoxŞifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(200, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(54, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(701, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "YURT ÖĞRENCİ TAKİP OTOMASYON";
            // 
            // FrmAdminEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 384);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxŞifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKullanıcıAD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminEkran";
            this.Text = "FrmAdminEkran";
            this.Load += new System.EventHandler(this.FrmAdminEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxKullanıcıAD;
        private System.Windows.Forms.TextBox textBoxŞifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}