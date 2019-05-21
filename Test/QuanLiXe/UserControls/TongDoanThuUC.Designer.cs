﻿namespace QuanLiXe.UserControls
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.loaixeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOANHTHUGUIXEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._DESKTOP_RRRHOP4DoanhThu = new QuanLiXe._DESKTOP_RRRHOP4DoanhThu();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerToday = new System.Windows.Forms.DateTimePicker();
            this.dOANHTHUGUIXETableAdapter = new QuanLiXe._DESKTOP_RRRHOP4DoanhThuTableAdapters.DOANHTHUGUIXETableAdapter();
            this.chartDoanhthu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANHTHUGUIXEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_RRRHOP4DoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.AllowUserToResizeColumns = false;
            this.dgvThongKe.AllowUserToResizeRows = false;
            this.dgvThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongKe.AutoGenerateColumns = false;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("UVN Anh Hai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
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
            this.dgvThongKe.Location = new System.Drawing.Point(582, 108);
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
            this.dgvThongKe.Size = new System.Drawing.Size(495, 426);
            this.dgvThongKe.TabIndex = 68;
            // 
            // loaixeDataGridViewTextBoxColumn
            // 
            this.loaixeDataGridViewTextBoxColumn.DataPropertyName = "loaixe";
            this.loaixeDataGridViewTextBoxColumn.HeaderText = "Loại xe";
            this.loaixeDataGridViewTextBoxColumn.Name = "loaixeDataGridViewTextBoxColumn";
            this.loaixeDataGridViewTextBoxColumn.Width = 119;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            this.soluongDataGridViewTextBoxColumn.Width = 133;
            // 
            // tongtienDataGridViewTextBoxColumn
            // 
            this.tongtienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongtienDataGridViewTextBoxColumn.DataPropertyName = "tongtien";
            this.tongtienDataGridViewTextBoxColumn.HeaderText = "Tổng kết cuối ngày";
            this.tongtienDataGridViewTextBoxColumn.Name = "tongtienDataGridViewTextBoxColumn";
            // 
            // dOANHTHUGUIXEBindingSource
            // 
            this.dOANHTHUGUIXEBindingSource.DataMember = "DOANHTHUGUIXE";
            this.dOANHTHUGUIXEBindingSource.DataSource = this._DESKTOP_RRRHOP4DoanhThu;
            // 
            // _DESKTOP_RRRHOP4DoanhThu
            // 
            this._DESKTOP_RRRHOP4DoanhThu.DataSetName = "_DESKTOP_RRRHOP4DoanhThu";
            this._DESKTOP_RRRHOP4DoanhThu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(898, 61);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(179, 41);
            this.dateTimePicker.TabIndex = 69;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 66);
            this.button1.TabIndex = 70;
            this.button1.Text = "Lưu doanh thu cuối ngày";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerToday
            // 
            this.dateTimePickerToday.CalendarFont = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerToday.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerToday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToday.Location = new System.Drawing.Point(213, 30);
            this.dateTimePickerToday.Name = "dateTimePickerToday";
            this.dateTimePickerToday.Size = new System.Drawing.Size(179, 41);
            this.dateTimePickerToday.TabIndex = 71;
            // 
            // dOANHTHUGUIXETableAdapter
            // 
            this.dOANHTHUGUIXETableAdapter.ClearBeforeFill = true;
            // 
            // chartDoanhthu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhthu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhthu.Legends.Add(legend1);
            this.chartDoanhthu.Location = new System.Drawing.Point(41, 108);
            this.chartDoanhthu.Name = "chartDoanhthu";
            this.chartDoanhthu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartDoanhthu.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))))};
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.LightCoral;
            series1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series1.Legend = "Legend1";
            series1.Name = "Loại xe";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chartDoanhthu.Series.Add(series1);
            this.chartDoanhthu.Size = new System.Drawing.Size(690, 644);
            this.chartDoanhthu.TabIndex = 72;
            // 
            // TongDoanThuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.chartDoanhthu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.dateTimePickerToday);
            this.Name = "TongDoanThuUC";
            this.Size = new System.Drawing.Size(1080, 800);
            this.Load += new System.EventHandler(this.TongDoanThuUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANHTHUGUIXEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_RRRHOP4DoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhthu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerToday;
        private System.Windows.Forms.BindingSource dOANHTHUGUIXEBindingSource;
        private _DESKTOP_RRRHOP4DoanhThu _DESKTOP_RRRHOP4DoanhThu;
        private _DESKTOP_RRRHOP4DoanhThuTableAdapters.DOANHTHUGUIXETableAdapter dOANHTHUGUIXETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaixeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhthu;
    }
}
