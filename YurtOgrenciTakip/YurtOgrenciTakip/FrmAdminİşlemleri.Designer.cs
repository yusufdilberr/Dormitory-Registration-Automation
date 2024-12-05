namespace YurtOgrenciTakip
{
    partial class FrmAdminİşlemleri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminİşlemleri));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdminID = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.textBoxAdminNick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdminŞifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yurtOgrenciTakipDataSet6 = new YurtOgrenciTakip.YurtOgrenciTakipDataSet6();
            this.yöneticiBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yöneticiBilgisiTableAdapter = new YurtOgrenciTakip.YurtOgrenciTakipDataSet6TableAdapters.YöneticiBilgisiTableAdapter();
            this.yöneticiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yöneticiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yöneticiSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOgrenciTakipDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yöneticiBilgisiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici Id:";
            // 
            // textBoxAdminID
            // 
            this.textBoxAdminID.Location = new System.Drawing.Point(121, 21);
            this.textBoxAdminID.Name = "textBoxAdminID";
            this.textBoxAdminID.Size = new System.Drawing.Size(229, 22);
            this.textBoxAdminID.TabIndex = 1;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(12, 175);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(155, 35);
            this.buttonKaydet.TabIndex = 2;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yöneticiIDDataGridViewTextBoxColumn,
            this.yöneticiAdDataGridViewTextBoxColumn,
            this.yöneticiSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yöneticiBilgisiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(540, 196);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(208, 175);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(155, 35);
            this.buttonSil.TabIndex = 4;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.Location = new System.Drawing.Point(393, 175);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(155, 35);
            this.buttonGüncelle.TabIndex = 5;
            this.buttonGüncelle.Text = "Güncelle";
            this.buttonGüncelle.UseVisualStyleBackColor = true;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // textBoxAdminNick
            // 
            this.textBoxAdminNick.Location = new System.Drawing.Point(121, 67);
            this.textBoxAdminNick.Name = "textBoxAdminNick";
            this.textBoxAdminNick.Size = new System.Drawing.Size(229, 22);
            this.textBoxAdminNick.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // textBoxAdminŞifre
            // 
            this.textBoxAdminŞifre.Location = new System.Drawing.Point(121, 123);
            this.textBoxAdminŞifre.Name = "textBoxAdminŞifre";
            this.textBoxAdminŞifre.Size = new System.Drawing.Size(229, 22);
            this.textBoxAdminŞifre.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre";
            // 
            // yurtOgrenciTakipDataSet6
            // 
            this.yurtOgrenciTakipDataSet6.DataSetName = "YurtOgrenciTakipDataSet6";
            this.yurtOgrenciTakipDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yöneticiBilgisiBindingSource
            // 
            this.yöneticiBilgisiBindingSource.DataMember = "YöneticiBilgisi";
            this.yöneticiBilgisiBindingSource.DataSource = this.yurtOgrenciTakipDataSet6;
            // 
            // yöneticiBilgisiTableAdapter
            // 
            this.yöneticiBilgisiTableAdapter.ClearBeforeFill = true;
            // 
            // yöneticiIDDataGridViewTextBoxColumn
            // 
            this.yöneticiIDDataGridViewTextBoxColumn.DataPropertyName = "YöneticiID";
            this.yöneticiIDDataGridViewTextBoxColumn.HeaderText = "YöneticiID";
            this.yöneticiIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yöneticiIDDataGridViewTextBoxColumn.Name = "yöneticiIDDataGridViewTextBoxColumn";
            this.yöneticiIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.yöneticiIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // yöneticiAdDataGridViewTextBoxColumn
            // 
            this.yöneticiAdDataGridViewTextBoxColumn.DataPropertyName = "YöneticiAd";
            this.yöneticiAdDataGridViewTextBoxColumn.HeaderText = "YöneticiAd";
            this.yöneticiAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yöneticiAdDataGridViewTextBoxColumn.Name = "yöneticiAdDataGridViewTextBoxColumn";
            this.yöneticiAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // yöneticiSifreDataGridViewTextBoxColumn
            // 
            this.yöneticiSifreDataGridViewTextBoxColumn.DataPropertyName = "YöneticiSifre";
            this.yöneticiSifreDataGridViewTextBoxColumn.HeaderText = "YöneticiSifre";
            this.yöneticiSifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yöneticiSifreDataGridViewTextBoxColumn.Name = "yöneticiSifreDataGridViewTextBoxColumn";
            this.yöneticiSifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmAdminİşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.textBoxAdminŞifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAdminNick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.textBoxAdminID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminİşlemleri";
            this.Text = "FrmAdminİşlemleri";
            this.Load += new System.EventHandler(this.FrmAdminİşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOgrenciTakipDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yöneticiBilgisiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdminID;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.TextBox textBoxAdminNick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdminŞifre;
        private System.Windows.Forms.Label label3;
        private YurtOgrenciTakipDataSet6 yurtOgrenciTakipDataSet6;
        private System.Windows.Forms.BindingSource yöneticiBilgisiBindingSource;
        private YurtOgrenciTakipDataSet6TableAdapters.YöneticiBilgisiTableAdapter yöneticiBilgisiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yöneticiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yöneticiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yöneticiSifreDataGridViewTextBoxColumn;
    }
}