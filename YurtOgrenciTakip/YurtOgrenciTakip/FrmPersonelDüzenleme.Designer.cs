namespace YurtOgrenciTakip
{
    partial class FrmPersonelDüzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelDüzenleme));
            this.textBoxPersID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPersAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPersDep = new System.Windows.Forms.ComboBox();
            this.buttonKayıt = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtOgrenciTakipDataSet7 = new YurtOgrenciTakip.YurtOgrenciTakipDataSet7();
            this.personelBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelBilgisiTableAdapter = new YurtOgrenciTakip.YurtOgrenciTakipDataSet7TableAdapters.PersonelBilgisiTableAdapter();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOgrenciTakipDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgisiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPersID
            // 
            this.textBoxPersID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPersID.Location = new System.Drawing.Point(230, 38);
            this.textBoxPersID.Name = "textBoxPersID";
            this.textBoxPersID.Size = new System.Drawing.Size(229, 22);
            this.textBoxPersID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(101, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel ID:";
            // 
            // textBoxPersAd
            // 
            this.textBoxPersAd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPersAd.Location = new System.Drawing.Point(230, 87);
            this.textBoxPersAd.Name = "textBoxPersAd";
            this.textBoxPersAd.Size = new System.Drawing.Size(229, 22);
            this.textBoxPersAd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(101, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel Departman:";
            // 
            // comboBoxPersDep
            // 
            this.comboBoxPersDep.FormattingEnabled = true;
            this.comboBoxPersDep.Location = new System.Drawing.Point(226, 143);
            this.comboBoxPersDep.Name = "comboBoxPersDep";
            this.comboBoxPersDep.Size = new System.Drawing.Size(233, 24);
            this.comboBoxPersDep.TabIndex = 7;
            // 
            // buttonKayıt
            // 
            this.buttonKayıt.Location = new System.Drawing.Point(45, 221);
            this.buttonKayıt.Name = "buttonKayıt";
            this.buttonKayıt.Size = new System.Drawing.Size(161, 41);
            this.buttonKayıt.TabIndex = 8;
            this.buttonKayıt.Text = "Kaydet";
            this.buttonKayıt.UseVisualStyleBackColor = true;
            this.buttonKayıt.Click += new System.EventHandler(this.buttonKayıt_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(280, 221);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(161, 41);
            this.buttonSil.TabIndex = 9;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.Location = new System.Drawing.Point(498, 221);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(161, 41);
            this.buttonGüncelle.TabIndex = 10;
            this.buttonGüncelle.Text = "Güncelle";
            this.buttonGüncelle.UseVisualStyleBackColor = true;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIDDataGridViewTextBoxColumn,
            this.personelAdSoyadDataGridViewTextBoxColumn,
            this.personelDepartmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBilgisiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(647, 227);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yurtOgrenciTakipDataSet7
            // 
            this.yurtOgrenciTakipDataSet7.DataSetName = "YurtOgrenciTakipDataSet7";
            this.yurtOgrenciTakipDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBilgisiBindingSource
            // 
            this.personelBilgisiBindingSource.DataMember = "PersonelBilgisi";
            this.personelBilgisiBindingSource.DataSource = this.yurtOgrenciTakipDataSet7;
            // 
            // personelBilgisiTableAdapter
            // 
            this.personelBilgisiTableAdapter.ClearBeforeFill = true;
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
            this.personelAdSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelDepartmanDataGridViewTextBoxColumn
            // 
            this.personelDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.HeaderText = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelDepartmanDataGridViewTextBoxColumn.Name = "personelDepartmanDataGridViewTextBoxColumn";
            this.personelDepartmanDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmPersonelDüzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonKayıt);
            this.Controls.Add(this.comboBoxPersDep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPersAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPersID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPersonelDüzenleme";
            this.Text = "FrmPersonelDüzenleme";
            this.Load += new System.EventHandler(this.FrmPersonelDüzenleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOgrenciTakipDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgisiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPersID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPersAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPersDep;
        private System.Windows.Forms.Button buttonKayıt;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOgrenciTakipDataSet7 yurtOgrenciTakipDataSet7;
        private System.Windows.Forms.BindingSource personelBilgisiBindingSource;
        private YurtOgrenciTakipDataSet7TableAdapters.PersonelBilgisiTableAdapter personelBilgisiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
    }
}