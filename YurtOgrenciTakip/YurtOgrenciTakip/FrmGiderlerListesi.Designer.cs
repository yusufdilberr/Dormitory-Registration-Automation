namespace YurtOgrenciTakip
{
    partial class FrmGiderlerListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderlerListesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtOgrenciTakipDataSet5 = new YurtOgrenciTakip.YurtOgrenciTakipDataSet5();
            this.giderlerBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giderlerBilgisiTableAdapter = new YurtOgrenciTakip.YurtOgrenciTakipDataSet5TableAdapters.GiderlerBilgisiTableAdapter();
            this.odemeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektrikGideriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suGideriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogalgazGideriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınternetGideriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gıdaGideriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelGideriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digerGiderlerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOgrenciTakipDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBilgisiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeIDDataGridViewTextBoxColumn,
            this.elektrikGideriDataGridViewTextBoxColumn,
            this.suGideriDataGridViewTextBoxColumn,
            this.dogalgazGideriDataGridViewTextBoxColumn,
            this.ınternetGideriDataGridViewTextBoxColumn,
            this.gıdaGideriDataGridViewTextBoxColumn,
            this.personelGideriDataGridViewTextBoxColumn,
            this.digerGiderlerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giderlerBilgisiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1385, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yurtOgrenciTakipDataSet5
            // 
            this.yurtOgrenciTakipDataSet5.DataSetName = "YurtOgrenciTakipDataSet5";
            this.yurtOgrenciTakipDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderlerBilgisiBindingSource
            // 
            this.giderlerBilgisiBindingSource.DataMember = "GiderlerBilgisi";
            this.giderlerBilgisiBindingSource.DataSource = this.yurtOgrenciTakipDataSet5;
            // 
            // giderlerBilgisiTableAdapter
            // 
            this.giderlerBilgisiTableAdapter.ClearBeforeFill = true;
            // 
            // odemeIDDataGridViewTextBoxColumn
            // 
            this.odemeIDDataGridViewTextBoxColumn.DataPropertyName = "OdemeID";
            this.odemeIDDataGridViewTextBoxColumn.HeaderText = "OdemeID";
            this.odemeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeIDDataGridViewTextBoxColumn.Name = "odemeIDDataGridViewTextBoxColumn";
            this.odemeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.odemeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // elektrikGideriDataGridViewTextBoxColumn
            // 
            this.elektrikGideriDataGridViewTextBoxColumn.DataPropertyName = "ElektrikGideri";
            this.elektrikGideriDataGridViewTextBoxColumn.HeaderText = "ElektrikGideri";
            this.elektrikGideriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elektrikGideriDataGridViewTextBoxColumn.Name = "elektrikGideriDataGridViewTextBoxColumn";
            this.elektrikGideriDataGridViewTextBoxColumn.Width = 125;
            // 
            // suGideriDataGridViewTextBoxColumn
            // 
            this.suGideriDataGridViewTextBoxColumn.DataPropertyName = "SuGideri";
            this.suGideriDataGridViewTextBoxColumn.HeaderText = "SuGideri";
            this.suGideriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suGideriDataGridViewTextBoxColumn.Name = "suGideriDataGridViewTextBoxColumn";
            this.suGideriDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogalgazGideriDataGridViewTextBoxColumn
            // 
            this.dogalgazGideriDataGridViewTextBoxColumn.DataPropertyName = "DogalgazGideri";
            this.dogalgazGideriDataGridViewTextBoxColumn.HeaderText = "DogalgazGideri";
            this.dogalgazGideriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogalgazGideriDataGridViewTextBoxColumn.Name = "dogalgazGideriDataGridViewTextBoxColumn";
            this.dogalgazGideriDataGridViewTextBoxColumn.Width = 125;
            // 
            // ınternetGideriDataGridViewTextBoxColumn
            // 
            this.ınternetGideriDataGridViewTextBoxColumn.DataPropertyName = "InternetGideri";
            this.ınternetGideriDataGridViewTextBoxColumn.HeaderText = "InternetGideri";
            this.ınternetGideriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ınternetGideriDataGridViewTextBoxColumn.Name = "ınternetGideriDataGridViewTextBoxColumn";
            this.ınternetGideriDataGridViewTextBoxColumn.Width = 125;
            // 
            // gıdaGideriDataGridViewTextBoxColumn
            // 
            this.gıdaGideriDataGridViewTextBoxColumn.DataPropertyName = "GıdaGideri";
            this.gıdaGideriDataGridViewTextBoxColumn.HeaderText = "GıdaGideri";
            this.gıdaGideriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gıdaGideriDataGridViewTextBoxColumn.Name = "gıdaGideriDataGridViewTextBoxColumn";
            this.gıdaGideriDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelGideriDataGridViewTextBoxColumn
            // 
            this.personelGideriDataGridViewTextBoxColumn.DataPropertyName = "PersonelGideri";
            this.personelGideriDataGridViewTextBoxColumn.HeaderText = "PersonelGideri";
            this.personelGideriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelGideriDataGridViewTextBoxColumn.Name = "personelGideriDataGridViewTextBoxColumn";
            this.personelGideriDataGridViewTextBoxColumn.Width = 125;
            // 
            // digerGiderlerDataGridViewTextBoxColumn
            // 
            this.digerGiderlerDataGridViewTextBoxColumn.DataPropertyName = "DigerGiderler";
            this.digerGiderlerDataGridViewTextBoxColumn.HeaderText = "DigerGiderler";
            this.digerGiderlerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.digerGiderlerDataGridViewTextBoxColumn.Name = "digerGiderlerDataGridViewTextBoxColumn";
            this.digerGiderlerDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmGiderlerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiderlerListesi";
            this.Text = "FrmGiderlerListesi";
            this.Load += new System.EventHandler(this.FrmGiderlerListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOgrenciTakipDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBilgisiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOgrenciTakipDataSet5 yurtOgrenciTakipDataSet5;
        private System.Windows.Forms.BindingSource giderlerBilgisiBindingSource;
        private YurtOgrenciTakipDataSet5TableAdapters.GiderlerBilgisiTableAdapter giderlerBilgisiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektrikGideriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suGideriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogalgazGideriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınternetGideriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gıdaGideriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelGideriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digerGiderlerDataGridViewTextBoxColumn;
    }
}