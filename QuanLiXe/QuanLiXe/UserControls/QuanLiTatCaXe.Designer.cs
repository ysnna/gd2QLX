namespace QuanLiXe.UserControls
{
    partial class QuanLiTatCaXe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLiTatCaXe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.labelQuaGioGui = new System.Windows.Forms.Label();
            this.labelDauSaiViTri = new System.Windows.Forms.Label();
            this.dgvQuanLiAllXe = new System.Windows.Forms.DataGridView();
            this.qUANLIXERAVAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._DESKTOP_RRRHOP4DataSet = new QuanLiXe._DESKTOP_RRRHOP4DataSet();
            this.pictureBoxXeMay = new System.Windows.Forms.PictureBox();
            this.pictureBoxOto = new System.Windows.Forms.PictureBox();
            this.pictureBoxXeDap = new System.Windows.Forms.PictureBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.qUANLIXERAVAOTableAdapter = new QuanLiXe._DESKTOP_RRRHOP4DataSetTableAdapters.QUANLIXERAVAOTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiAllXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLIXERAVAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_RRRHOP4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXeMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXeDap)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(191, 27);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 40);
            this.txtSearch.TabIndex = 52;
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefresh.BackgroundImage")));
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(107, 14);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(78, 63);
            this.pictureBoxRefresh.TabIndex = 57;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // labelQuaGioGui
            // 
            this.labelQuaGioGui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuaGioGui.AutoSize = true;
            this.labelQuaGioGui.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuaGioGui.Location = new System.Drawing.Point(848, 747);
            this.labelQuaGioGui.Name = "labelQuaGioGui";
            this.labelQuaGioGui.Size = new System.Drawing.Size(97, 21);
            this.labelQuaGioGui.TabIndex = 58;
            this.labelQuaGioGui.Text = "Quá giờ gửi";
            this.labelQuaGioGui.Visible = false;
            // 
            // labelDauSaiViTri
            // 
            this.labelDauSaiViTri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDauSaiViTri.AutoSize = true;
            this.labelDauSaiViTri.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDauSaiViTri.Location = new System.Drawing.Point(839, 768);
            this.labelDauSaiViTri.Name = "labelDauSaiViTri";
            this.labelDauSaiViTri.Size = new System.Drawing.Size(106, 21);
            this.labelDauSaiViTri.TabIndex = 59;
            this.labelDauSaiViTri.Text = "Đậu sai vị trí";
            // 
            // dgvQuanLiAllXe
            // 
            this.dgvQuanLiAllXe.AllowUserToResizeColumns = false;
            this.dgvQuanLiAllXe.AllowUserToResizeRows = false;
            this.dgvQuanLiAllXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuanLiAllXe.AutoGenerateColumns = false;
            this.dgvQuanLiAllXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQuanLiAllXe.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("UVN Anh Hai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuanLiAllXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuanLiAllXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLiAllXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn2,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvQuanLiAllXe.DataSource = this.qUANLIXERAVAOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuanLiAllXe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuanLiAllXe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuanLiAllXe.Location = new System.Drawing.Point(0, 83);
            this.dgvQuanLiAllXe.Name = "dgvQuanLiAllXe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("UVN Anh Hai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanLiAllXe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuanLiAllXe.RowHeadersVisible = false;
            this.dgvQuanLiAllXe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvQuanLiAllXe.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQuanLiAllXe.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuanLiAllXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvQuanLiAllXe.Size = new System.Drawing.Size(1080, 660);
            this.dgvQuanLiAllXe.TabIndex = 60;
            // 
            // qUANLIXERAVAOBindingSource
            // 
            this.qUANLIXERAVAOBindingSource.DataMember = "QUANLIXERAVAO";
            this.qUANLIXERAVAOBindingSource.DataSource = this._DESKTOP_RRRHOP4DataSet;
            // 
            // _DESKTOP_RRRHOP4DataSet
            // 
            this._DESKTOP_RRRHOP4DataSet.DataSetName = "_DESKTOP_RRRHOP4DataSet";
            this._DESKTOP_RRRHOP4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBoxXeMay
            // 
            this.pictureBoxXeMay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxXeMay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxXeMay.BackgroundImage")));
            this.pictureBoxXeMay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxXeMay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxXeMay.Location = new System.Drawing.Point(779, 3);
            this.pictureBoxXeMay.Name = "pictureBoxXeMay";
            this.pictureBoxXeMay.Size = new System.Drawing.Size(101, 83);
            this.pictureBoxXeMay.TabIndex = 61;
            this.pictureBoxXeMay.TabStop = false;
            this.pictureBoxXeMay.Click += new System.EventHandler(this.pictureBoxXeMay_Click);
            // 
            // pictureBoxOto
            // 
            this.pictureBoxOto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxOto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxOto.BackgroundImage")));
            this.pictureBoxOto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxOto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOto.Image")));
            this.pictureBoxOto.Location = new System.Drawing.Point(878, 3);
            this.pictureBoxOto.Name = "pictureBoxOto";
            this.pictureBoxOto.Size = new System.Drawing.Size(99, 83);
            this.pictureBoxOto.TabIndex = 62;
            this.pictureBoxOto.TabStop = false;
            this.pictureBoxOto.Click += new System.EventHandler(this.pictureBoxOto_Click);
            // 
            // pictureBoxXeDap
            // 
            this.pictureBoxXeDap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxXeDap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxXeDap.BackgroundImage")));
            this.pictureBoxXeDap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxXeDap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxXeDap.Location = new System.Drawing.Point(972, 3);
            this.pictureBoxXeDap.Name = "pictureBoxXeDap";
            this.pictureBoxXeDap.Size = new System.Drawing.Size(101, 83);
            this.pictureBoxXeDap.TabIndex = 63;
            this.pictureBoxXeDap.TabStop = false;
            this.pictureBoxXeDap.Click += new System.EventHandler(this.pictureBoxXeDap_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSua.BackColor = System.Drawing.Color.LightCoral;
            this.btSua.Font = new System.Drawing.Font("UTM Centur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(951, 749);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(126, 46);
            this.btSua.TabIndex = 64;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click_1);
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.Transparent;
            this.btSearch.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btSearch.Location = new System.Drawing.Point(467, 27);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(85, 40);
            this.btSearch.TabIndex = 65;
            this.btSearch.Text = "OK";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btXoa.Font = new System.Drawing.Font("UTM Centur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(3, 749);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(182, 46);
            this.btXoa.TabIndex = 66;
            this.btXoa.Text = "Xóa tất cả";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // qUANLIXERAVAOTableAdapter
            // 
            this.qUANLIXERAVAOTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "loaixe";
            this.dataGridViewTextBoxColumn2.HeaderText = "Loại xe";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 119;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "vitri";
            this.dataGridViewTextBoxColumn1.HeaderText = "Vị trí";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 94;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "ava";
            this.dataGridViewImageColumn2.HeaderText = "Người gửi";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 123;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "bienso";
            this.dataGridViewImageColumn1.HeaderText = "Biển số";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 101;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ngayguixe";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày gửi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 133;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gioguixe";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giờ gửi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 118;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ngaylayxe";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày lấy";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 132;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "giolayxe";
            this.dataGridViewTextBoxColumn6.HeaderText = "Giờ lấy";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 117;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tongTime";
            this.dataGridViewTextBoxColumn7.HeaderText = "Thời gian thực";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 197;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "timeyeucau";
            this.dataGridViewTextBoxColumn8.HeaderText = "Yêu cầu gửi";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 163;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "tongtien";
            this.dataGridViewTextBoxColumn9.HeaderText = "Thành tiền";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // QuanLiTatCaXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.dgvQuanLiAllXe);
            this.Controls.Add(this.pictureBoxXeDap);
            this.Controls.Add(this.pictureBoxOto);
            this.Controls.Add(this.pictureBoxXeMay);
            this.Controls.Add(this.labelDauSaiViTri);
            this.Controls.Add(this.labelQuaGioGui);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.txtSearch);
            this.Name = "QuanLiTatCaXe";
            this.Size = new System.Drawing.Size(1080, 800);
            this.Load += new System.EventHandler(this.QuanLiTatCaXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiAllXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLIXERAVAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_RRRHOP4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXeMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXeDap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.Label labelQuaGioGui;
        private System.Windows.Forms.Label labelDauSaiViTri;
        private System.Windows.Forms.DataGridView dgvQuanLiAllXe;
        private System.Windows.Forms.PictureBox pictureBoxXeMay;
        private System.Windows.Forms.PictureBox pictureBoxOto;
        private System.Windows.Forms.PictureBox pictureBoxXeDap;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btXoa;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaixeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn avaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn biensoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayguixeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioguixeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylayxeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giolayxeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeyeucauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource qUANLIXERAVAOBindingSource;
        private _DESKTOP_RRRHOP4DataSet _DESKTOP_RRRHOP4DataSet;
        private _DESKTOP_RRRHOP4DataSetTableAdapters.QUANLIXERAVAOTableAdapter qUANLIXERAVAOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
