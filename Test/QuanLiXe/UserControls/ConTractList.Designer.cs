namespace QuanLiXe.UserControls
{
    partial class HopDongGui
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddCon = new System.Windows.Forms.Button();
            this.dgvCon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(62, 77);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(428, 43);
            this.txtSearch.TabIndex = 6;
            // 
            // btnAddCon
            // 
            this.btnAddCon.Location = new System.Drawing.Point(695, 77);
            this.btnAddCon.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCon.Name = "btnAddCon";
            this.btnAddCon.Size = new System.Drawing.Size(139, 38);
            this.btnAddCon.TabIndex = 5;
            this.btnAddCon.Text = "Thêm Hợp Động";
            this.btnAddCon.UseVisualStyleBackColor = true;
            this.btnAddCon.Click += new System.EventHandler(this.btnAddCon_Click);
            // 
            // dgvCon
            // 
            this.dgvCon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCon.Location = new System.Drawing.Point(36, 148);
            this.dgvCon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCon.Name = "dgvCon";
            this.dgvCon.RowTemplate.Height = 24;
            this.dgvCon.Size = new System.Drawing.Size(870, 314);
            this.dgvCon.TabIndex = 4;
            // 
            // HopDongGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddCon);
            this.Controls.Add(this.dgvCon);
            this.Name = "HopDongGui";
            this.Size = new System.Drawing.Size(1080, 800);
            this.Load += new System.EventHandler(this.HopDongGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddCon;
        private System.Windows.Forms.DataGridView dgvCon;
    }
}
