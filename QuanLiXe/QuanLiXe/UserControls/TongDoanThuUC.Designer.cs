namespace QuanLiXe.UserControls
{
    partial class TongDoanThuUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerToday = new System.Windows.Forms.DateTimePicker();
            this._DESKTOP_RRRHOP4DoanhThu = new QuanLiXe._DESKTOP_RRRHOP4DoanhThu();
            this.dOANHTHUGUIXEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOANHTHUGUIXETableAdapter = new QuanLiXe._DESKTOP_RRRHOP4DoanhThuTableAdapters.DOANHTHUGUIXETableAdapter();
            this.loaixeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_RRRHOP4DoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANHTHUGUIXEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.AllowUserToResizeColumns = false;
            this.dgvThongKe.AllowUserToResizeRows = false;
            this.dgvThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongKe.AutoGenerateColumns = false;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("UVN Anh Hai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loaixeDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.tongtienDataGridViewTextBoxColumn});
            this.dgvThongKe.DataSource = this.dOANHTHUGUIXEBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongKe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvThongKe.Location = new System.Drawing.Point(17, 80);
            this.dgvThongKe.Name = "dgvThongKe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("UVN Anh Hai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongKe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvThongKe.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThongKe.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(1045, 700);
            this.dgvThongKe.TabIndex = 68;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(883, 19);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(179, 41);
            this.dateTimePicker.TabIndex = 69;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 70;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerToday
            // 
            this.dateTimePickerToday.CalendarFont = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerToday.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerToday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToday.Location = new System.Drawing.Point(578, 19);
            this.dateTimePickerToday.Name = "dateTimePickerToday";
            this.dateTimePickerToday.Size = new System.Drawing.Size(179, 41);
            this.dateTimePickerToday.TabIndex = 71;
            // 
            // _DESKTOP_RRRHOP4DoanhThu
            // 
            this._DESKTOP_RRRHOP4DoanhThu.DataSetName = "_DESKTOP_RRRHOP4DoanhThu";
            this._DESKTOP_RRRHOP4DoanhThu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOANHTHUGUIXEBindingSource
            // 
            this.dOANHTHUGUIXEBindingSource.DataMember = "DOANHTHUGUIXE";
            this.dOANHTHUGUIXEBindingSource.DataSource = this._DESKTOP_RRRHOP4DoanhThu;
            // 
            // dOANHTHUGUIXETableAdapter
            // 
            this.dOANHTHUGUIXETableAdapter.ClearBeforeFill = true;
            // 
            // loaixeDataGridViewTextBoxColumn
            // 
            this.loaixeDataGridViewTextBoxColumn.DataPropertyName = "loaixe";
            this.loaixeDataGridViewTextBoxColumn.HeaderText = "Loại xe";
            this.loaixeDataGridViewTextBoxColumn.Name = "loaixeDataGridViewTextBoxColumn";
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            // 
            // tongtienDataGridViewTextBoxColumn
            // 
            this.tongtienDataGridViewTextBoxColumn.DataPropertyName = "tongtien";
            this.tongtienDataGridViewTextBoxColumn.HeaderText = "Tổng kết cuối ngày";
            this.tongtienDataGridViewTextBoxColumn.Name = "tongtienDataGridViewTextBoxColumn";
            // 
            // TongDoanThuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.dateTimePickerToday);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dgvThongKe);
            this.Name = "TongDoanThuUC";
            this.Size = new System.Drawing.Size(1080, 800);
            this.Load += new System.EventHandler(this.TongDoanThuUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_RRRHOP4DoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANHTHUGUIXEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerToday;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaixeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dOANHTHUGUIXEBindingSource;
        private _DESKTOP_RRRHOP4DoanhThu _DESKTOP_RRRHOP4DoanhThu;
        private _DESKTOP_RRRHOP4DoanhThuTableAdapters.DOANHTHUGUIXETableAdapter dOANHTHUGUIXETableAdapter;
    }
}
