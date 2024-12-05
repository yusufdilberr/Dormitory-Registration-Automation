namespace YurtOgrenciTakip
{
    partial class FrmOgrenciListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciListesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciTcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBolümDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciVeliAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciVeliTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciVeliAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOgrenciTakipDataSet4 = new YurtOgrenciTakip.YurtOgrenciTakipDataSet4();
            this.ogrenciBilgisiTableAdapter = new YurtOgrenciTakip.YurtOgrenciTakipDataSet4TableAdapters.OgrenciBilgisiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOgrenciTakipDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.ogrenciAdDataGridViewTextBoxColumn,
            this.ogrenciSoyadDataGridViewTextBoxColumn,
            this.ogrenciTcNoDataGridViewTextBoxColumn,
            this.ogrenciTelefonDataGridViewTextBoxColumn,
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn,
            this.ogrenciBolümDataGridViewTextBoxColumn,
            this.ogrenciMailDataGridViewTextBoxColumn,
            this.ogrenciOdaNoDataGridViewTextBoxColumn,
            this.ogrenciVeliAdSoyadDataGridViewTextBoxColumn,
            this.ogrenciVeliTelefonDataGridViewTextBoxColumn,
            this.ogrenciVeliAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBilgisiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1628, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrenciIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciAdDataGridViewTextBoxColumn
            // 
            this.ogrenciAdDataGridViewTextBoxColumn.DataPropertyName = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.HeaderText = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciAdDataGridViewTextBoxColumn.Name = "ogrenciAdDataGridViewTextBoxColumn";
            this.ogrenciAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.HeaderText = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciSoyadDataGridViewTextBoxColumn.Name = "ogrenciSoyadDataGridViewTextBoxColumn";
            this.ogrenciSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciTcNoDataGridViewTextBoxColumn
            // 
            this.ogrenciTcNoDataGridViewTextBoxColumn.DataPropertyName = "OgrenciTcNo";
            this.ogrenciTcNoDataGridViewTextBoxColumn.HeaderText = "OgrenciTcNo";
            this.ogrenciTcNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciTcNoDataGridViewTextBoxColumn.Name = "ogrenciTcNoDataGridViewTextBoxColumn";
            this.ogrenciTcNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciTelefonDataGridViewTextBoxColumn
            // 
            this.ogrenciTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrenciTelefon";
            this.ogrenciTelefonDataGridViewTextBoxColumn.HeaderText = "OgrenciTelefon";
            this.ogrenciTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciTelefonDataGridViewTextBoxColumn.Name = "ogrenciTelefonDataGridViewTextBoxColumn";
            this.ogrenciTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciDogumTarihiDataGridViewTextBoxColumn
            // 
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "OgrenciDogumTarihi";
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn.HeaderText = "OgrenciDogumTarihi";
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn.Name = "ogrenciDogumTarihiDataGridViewTextBoxColumn";
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciBolümDataGridViewTextBoxColumn
            // 
            this.ogrenciBolümDataGridViewTextBoxColumn.DataPropertyName = "OgrenciBolüm";
            this.ogrenciBolümDataGridViewTextBoxColumn.HeaderText = "OgrenciBolüm";
            this.ogrenciBolümDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciBolümDataGridViewTextBoxColumn.Name = "ogrenciBolümDataGridViewTextBoxColumn";
            this.ogrenciBolümDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciMailDataGridViewTextBoxColumn
            // 
            this.ogrenciMailDataGridViewTextBoxColumn.DataPropertyName = "OgrenciMail";
            this.ogrenciMailDataGridViewTextBoxColumn.HeaderText = "OgrenciMail";
            this.ogrenciMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciMailDataGridViewTextBoxColumn.Name = "ogrenciMailDataGridViewTextBoxColumn";
            this.ogrenciMailDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciOdaNoDataGridViewTextBoxColumn
            // 
            this.ogrenciOdaNoDataGridViewTextBoxColumn.DataPropertyName = "OgrenciOdaNo";
            this.ogrenciOdaNoDataGridViewTextBoxColumn.HeaderText = "OgrenciOdaNo";
            this.ogrenciOdaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciOdaNoDataGridViewTextBoxColumn.Name = "ogrenciOdaNoDataGridViewTextBoxColumn";
            this.ogrenciOdaNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciVeliAdSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciVeliAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrenciVeliAdSoyad";
            this.ogrenciVeliAdSoyadDataGridViewTextBoxColumn.HeaderText = "OgrenciVeliAdSoyad";
            this.ogrenciVeliAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciVeliAdSoyadDataGridViewTextBoxColumn.Name = "ogrenciVeliAdSoyadDataGridViewTextBoxColumn";
            this.ogrenciVeliAdSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciVeliTelefonDataGridViewTextBoxColumn
            // 
            this.ogrenciVeliTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrenciVeliTelefon";
            this.ogrenciVeliTelefonDataGridViewTextBoxColumn.HeaderText = "OgrenciVeliTelefon";
            this.ogrenciVeliTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciVeliTelefonDataGridViewTextBoxColumn.Name = "ogrenciVeliTelefonDataGridViewTextBoxColumn";
            this.ogrenciVeliTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciVeliAdresDataGridViewTextBoxColumn
            // 
            this.ogrenciVeliAdresDataGridViewTextBoxColumn.DataPropertyName = "OgrenciVeliAdres";
            this.ogrenciVeliAdresDataGridViewTextBoxColumn.HeaderText = "OgrenciVeliAdres";
            this.ogrenciVeliAdresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciVeliAdresDataGridViewTextBoxColumn.Name = "ogrenciVeliAdresDataGridViewTextBoxColumn";
            this.ogrenciVeliAdresDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciBilgisiBindingSource
            // 
            this.ogrenciBilgisiBindingSource.DataMember = "OgrenciBilgisi";
            this.ogrenciBilgisiBindingSource.DataSource = this.yurtOgrenciTakipDataSet4;
            // 
            // yurtOgrenciTakipDataSet4
            // 
            this.yurtOgrenciTakipDataSet4.DataSetName = "YurtOgrenciTakipDataSet4";
            this.yurtOgrenciTakipDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBilgisiTableAdapter
            // 
            this.ogrenciBilgisiTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1761, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrenciListesi";
            this.Text = "FrmOgrenciListesi";
            this.Load += new System.EventHandler(this.FrmOgrenciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOgrenciTakipDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOgrenciTakipDataSet4 yurtOgrenciTakipDataSet4;
        private System.Windows.Forms.BindingSource ogrenciBilgisiBindingSource;
        private YurtOgrenciTakipDataSet4TableAdapters.OgrenciBilgisiTableAdapter ogrenciBilgisiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciTcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciDogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciBolümDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciVeliAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciVeliTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciVeliAdresDataGridViewTextBoxColumn;
    }
}