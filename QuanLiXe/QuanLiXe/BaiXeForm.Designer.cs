namespace QuanLiXe
{
    partial class BaiXeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaiXeForm));
            this.dgvBaiXe = new System.Windows.Forms.DataGridView();
            this.btBaiOto = new System.Windows.Forms.Button();
            this.btBaiXeMay = new System.Windows.Forms.Button();
            this.btBaiXeDap = new System.Windows.Forms.Button();
            this.btBackThoat = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this._DESKTOP_RRRHOP4DataSet1 = new QuanLiXe._DESKTOP_RRRHOP4DataSet1();
            this.bAIXEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAIXETableAdapter = new QuanLiXe._DESKTOP_RRRHOP4DataSet1TableAdapters.BAIXETableAdapter();
            this.vitriXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_RRRHOP4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIXEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaiXe
            // 
            this.dgvBaiXe.AllowUserToAddRows = false;
            this.dgvBaiXe.AllowUserToDeleteRows = false;
            this.dgvBaiXe.AllowUserToResizeColumns = false;
            this.dgvBaiXe.AllowUserToResizeRows = false;
            this.dgvBaiXe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBaiXe.AutoGenerateColumns = false;
            this.dgvBaiXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBaiXe.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaiXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaiXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaiXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vitriXeDataGridViewTextBoxColumn,
            this.aDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn,
            this.eDataGridViewTextBoxColumn,
            this.fDataGridViewTextBoxColumn,
            this.gDataGridViewTextBoxColumn,
            this.hDataGridViewTextBoxColumn,
            this.kDataGridViewTextBoxColumn});
            this.dgvBaiXe.DataSource = this.bAIXEBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaiXe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBaiXe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBaiXe.Enabled = false;
            this.dgvBaiXe.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvBaiXe.Location = new System.Drawing.Point(10, 68);
            this.dgvBaiXe.Name = "dgvBaiXe";
            this.dgvBaiXe.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaiXe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBaiXe.RowHeadersVisible = false;
            this.dgvBaiXe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvBaiXe.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBaiXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBaiXe.Size = new System.Drawing.Size(1187, 662);
            this.dgvBaiXe.TabIndex = 0;
            // 
            // btBaiOto
            // 
            this.btBaiOto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBaiOto.BackColor = System.Drawing.Color.HotPink;
            this.btBaiOto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaiOto.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaiOto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBaiOto.Location = new System.Drawing.Point(147, 8);
            this.btBaiOto.Name = "btBaiOto";
            this.btBaiOto.Size = new System.Drawing.Size(350, 61);
            this.btBaiOto.TabIndex = 1;
            this.btBaiOto.Text = "Bãi xe ô tô";
            this.btBaiOto.UseVisualStyleBackColor = false;
            // 
            // btBaiXeMay
            // 
            this.btBaiXeMay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBaiXeMay.BackColor = System.Drawing.Color.RoyalBlue;
            this.btBaiXeMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaiXeMay.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaiXeMay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBaiXeMay.Location = new System.Drawing.Point(495, 8);
            this.btBaiXeMay.Name = "btBaiXeMay";
            this.btBaiXeMay.Size = new System.Drawing.Size(464, 61);
            this.btBaiXeMay.TabIndex = 2;
            this.btBaiXeMay.Text = "Bãi xe máy";
            this.btBaiXeMay.UseVisualStyleBackColor = false;
            // 
            // btBaiXeDap
            // 
            this.btBaiXeDap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBaiXeDap.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btBaiXeDap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaiXeDap.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaiXeDap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBaiXeDap.Location = new System.Drawing.Point(958, 8);
            this.btBaiXeDap.Name = "btBaiXeDap";
            this.btBaiXeDap.Size = new System.Drawing.Size(239, 61);
            this.btBaiXeDap.TabIndex = 3;
            this.btBaiXeDap.Text = "Bãi xe đạp";
            this.btBaiXeDap.UseVisualStyleBackColor = false;
            // 
            // btBackThoat
            // 
            this.btBackThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBackThoat.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btBackThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBackThoat.BackgroundImage")));
            this.btBackThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btBackThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBackThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBackThoat.Location = new System.Drawing.Point(10, 8);
            this.btBackThoat.Name = "btBackThoat";
            this.btBackThoat.Size = new System.Drawing.Size(80, 63);
            this.btBackThoat.TabIndex = 4;
            this.btBackThoat.UseVisualStyleBackColor = false;
            this.btBackThoat.Click += new System.EventHandler(this.btBackThoat_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRefresh.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRefresh.BackgroundImage")));
            this.btRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRefresh.Location = new System.Drawing.Point(85, 8);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(62, 61);
            this.btRefresh.TabIndex = 5;
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // _DESKTOP_RRRHOP4DataSet1
            // 
            this._DESKTOP_RRRHOP4DataSet1.DataSetName = "_DESKTOP_RRRHOP4DataSet1";
            this._DESKTOP_RRRHOP4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bAIXEBindingSource
            // 
            this.bAIXEBindingSource.DataMember = "BAIXE";
            this.bAIXEBindingSource.DataSource = this._DESKTOP_RRRHOP4DataSet1;
            // 
            // bAIXETableAdapter
            // 
            this.bAIXETableAdapter.ClearBeforeFill = true;
            // 
            // vitriXeDataGridViewTextBoxColumn
            // 
            this.vitriXeDataGridViewTextBoxColumn.DataPropertyName = "vitriXe";
            this.vitriXeDataGridViewTextBoxColumn.HeaderText = "Vị trí xe";
            this.vitriXeDataGridViewTextBoxColumn.Name = "vitriXeDataGridViewTextBoxColumn";
            this.vitriXeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vitriXeDataGridViewTextBoxColumn.Width = 134;
            // 
            // aDataGridViewTextBoxColumn
            // 
            this.aDataGridViewTextBoxColumn.DataPropertyName = "A";
            this.aDataGridViewTextBoxColumn.HeaderText = "Khu A";
            this.aDataGridViewTextBoxColumn.Name = "aDataGridViewTextBoxColumn";
            this.aDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDataGridViewTextBoxColumn.Width = 115;
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "B";
            this.bDataGridViewTextBoxColumn.HeaderText = "Khu B";
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            this.bDataGridViewTextBoxColumn.ReadOnly = true;
            this.bDataGridViewTextBoxColumn.Width = 115;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "Khu C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDataGridViewTextBoxColumn.Width = 117;
            // 
            // dDataGridViewTextBoxColumn
            // 
            this.dDataGridViewTextBoxColumn.DataPropertyName = "D";
            this.dDataGridViewTextBoxColumn.HeaderText = "Khu D";
            this.dDataGridViewTextBoxColumn.Name = "dDataGridViewTextBoxColumn";
            this.dDataGridViewTextBoxColumn.ReadOnly = true;
            this.dDataGridViewTextBoxColumn.Width = 117;
            // 
            // eDataGridViewTextBoxColumn
            // 
            this.eDataGridViewTextBoxColumn.DataPropertyName = "E";
            this.eDataGridViewTextBoxColumn.HeaderText = "Khu E";
            this.eDataGridViewTextBoxColumn.Name = "eDataGridViewTextBoxColumn";
            this.eDataGridViewTextBoxColumn.ReadOnly = true;
            this.eDataGridViewTextBoxColumn.Width = 115;
            // 
            // fDataGridViewTextBoxColumn
            // 
            this.fDataGridViewTextBoxColumn.DataPropertyName = "F";
            this.fDataGridViewTextBoxColumn.HeaderText = "Khu F";
            this.fDataGridViewTextBoxColumn.Name = "fDataGridViewTextBoxColumn";
            this.fDataGridViewTextBoxColumn.ReadOnly = true;
            this.fDataGridViewTextBoxColumn.Width = 114;
            // 
            // gDataGridViewTextBoxColumn
            // 
            this.gDataGridViewTextBoxColumn.DataPropertyName = "G";
            this.gDataGridViewTextBoxColumn.HeaderText = "Khu G";
            this.gDataGridViewTextBoxColumn.Name = "gDataGridViewTextBoxColumn";
            this.gDataGridViewTextBoxColumn.ReadOnly = true;
            this.gDataGridViewTextBoxColumn.Width = 118;
            // 
            // hDataGridViewTextBoxColumn
            // 
            this.hDataGridViewTextBoxColumn.DataPropertyName = "H";
            this.hDataGridViewTextBoxColumn.HeaderText = "Khu H";
            this.hDataGridViewTextBoxColumn.Name = "hDataGridViewTextBoxColumn";
            this.hDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDataGridViewTextBoxColumn.Width = 118;
            // 
            // kDataGridViewTextBoxColumn
            // 
            this.kDataGridViewTextBoxColumn.DataPropertyName = "K";
            this.kDataGridViewTextBoxColumn.HeaderText = "Khu K";
            this.kDataGridViewTextBoxColumn.Name = "kDataGridViewTextBoxColumn";
            this.kDataGridViewTextBoxColumn.ReadOnly = true;
            this.kDataGridViewTextBoxColumn.Width = 118;
            // 
            // BaiXeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1206, 740);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btBaiXeDap);
            this.Controls.Add(this.btBaiXeMay);
            this.Controls.Add(this.btBaiOto);
            this.Controls.Add(this.dgvBaiXe);
            this.Controls.Add(this.btBackThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaiXeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaiXeForm";
            this.Load += new System.EventHandler(this.BaiXeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_RRRHOP4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIXEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaiXe;
        private System.Windows.Forms.Button btBaiOto;
        private System.Windows.Forms.Button btBaiXeMay;
        private System.Windows.Forms.Button btBaiXeDap;
        private System.Windows.Forms.Button btBackThoat;
        private System.Windows.Forms.Button btRefresh;
        private _DESKTOP_RRRHOP4DataSet1 _DESKTOP_RRRHOP4DataSet1;
        private System.Windows.Forms.BindingSource bAIXEBindingSource;
        private _DESKTOP_RRRHOP4DataSet1TableAdapters.BAIXETableAdapter bAIXETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitriXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kDataGridViewTextBoxColumn;
    }
}