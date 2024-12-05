namespace YurtOgrenciTakip
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.pictureBoxBolumEkle = new System.Windows.Forms.PictureBox();
            this.pictureBoxBolumSil = new System.Windows.Forms.PictureBox();
            this.pictureBoxBolumGüncelle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBolumID = new System.Windows.Forms.TextBox();
            this.txtBolumAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bolumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOgrenciTakipDataSet = new YurtOgrenciTakip.YurtOgrenciTakipDataSet();
            this.bolumBilgisiTableAdapter = new YurtOgrenciTakip.YurtOgrenciTakipDataSetTableAdapters.BolumBilgisiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBolumGüncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBilgisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOgrenciTakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBolumEkle
            // 
            this.pictureBoxBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBolumEkle.Image")));
            this.pictureBoxBolumEkle.Location = new System.Drawing.Point(438, 56);
            this.pictureBoxBolumEkle.Name = "pictureBoxBolumEkle";
            this.pictureBoxBolumEkle.Size = new System.Drawing.Size(87, 61);
            this.pictureBoxBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBolumEkle.TabIndex = 0;
            this.pictureBoxBolumEkle.TabStop = false;
            this.pictureBoxBolumEkle.Click += new System.EventHandler(this.pictureBoxBolumEkle_Click);
            // 
            // pictureBoxBolumSil
            // 
            this.pictureBoxBolumSil.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBolumSil.Image")));
            this.pictureBoxBolumSil.Location = new System.Drawing.Point(549, 56);
            this.pictureBoxBolumSil.Name = "pictureBoxBolumSil";
            this.pictureBoxBolumSil.Size = new System.Drawing.Size(78, 61);
            this.pictureBoxBolumSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBolumSil.TabIndex = 1;
            this.pictureBoxBolumSil.TabStop = false;
            this.pictureBoxBolumSil.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxBolumGüncelle
            // 
            this.pictureBoxBolumGüncelle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBolumGüncelle.Image")));
            this.pictureBoxBolumGüncelle.Location = new System.Drawing.Point(650, 56);
            this.pictureBoxBolumGüncelle.Name = "pictureBoxBolumGüncelle";
            this.pictureBoxBolumGüncelle.Size = new System.Drawing.Size(80, 61);
            this.pictureBoxBolumGüncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBolumGüncelle.TabIndex = 2;
            this.pictureBoxBolumGüncelle.TabStop = false;
            this.pictureBoxBolumGüncelle.Click += new System.EventHandler(this.pictureBoxBolumGüncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "BÖLÜM ID:";
            // 
            // TxtBolumID
            // 
            this.TxtBolumID.Location = new System.Drawing.Point(183, 41);
            this.TxtBolumID.Name = "TxtBolumID";
            this.TxtBolumID.Size = new System.Drawing.Size(230, 22);
            this.TxtBolumID.TabIndex = 4;
            // 
            // txtBolumAdı
            // 
            this.txtBolumAdı.Location = new System.Drawing.Point(183, 95);
            this.txtBolumAdı.Name = "txtBolumAdı";
            this.txtBolumAdı.Size = new System.Drawing.Size(230, 22);
            this.txtBolumAdı.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "BÖLÜM ADI:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumIDDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bolumBilgisiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(18, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(738, 421);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // bolumIDDataGridViewTextBoxColumn
            // 
            this.bolumIDDataGridViewTextBoxColumn.DataPropertyName = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.HeaderText = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumIDDataGridViewTextBoxColumn.Name = "bolumIDDataGridViewTextBoxColumn";
            this.bolumIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bolumIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumBilgisiBindingSource
            // 
            this.bolumBilgisiBindingSource.DataMember = "BolumBilgisi";
            this.bolumBilgisiBindingSource.DataSource = this.yurtOgrenciTakipDataSet;
            // 
            // yurtOgrenciTakipDataSet
            // 
            this.yurtOgrenciTakipDataSet.DataSetName = "YurtOgrenciTakipDataSet";
            this.yurtOgrenciTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumBilgisiTableAdapter
            // 
            this.bolumBilgisiTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(768, 601);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtBolumAdı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBolumID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxBolumGüncelle);
            this.Controls.Add(this.pictureBoxBolumSil);
            this.Controls.Add(this.pictureBoxBolumEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "FrmBolumler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBolumGüncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBilgisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOgrenciTakipDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBolumEkle;
        private System.Windows.Forms.PictureBox pictureBoxBolumSil;
        private System.Windows.Forms.PictureBox pictureBoxBolumGüncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBolumID;
        private System.Windows.Forms.TextBox txtBolumAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private YurtOgrenciTakipDataSet yurtOgrenciTakipDataSet;
        private System.Windows.Forms.BindingSource bolumBilgisiBindingSource;
        private YurtOgrenciTakipDataSetTableAdapters.BolumBilgisiTableAdapter bolumBilgisiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
    }
}