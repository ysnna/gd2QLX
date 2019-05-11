namespace _17110094_NguyenAnh_Login
{
    partial class StaticResult
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbFail = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewAVG = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Static by Course";
            // 
            // lbFail
            // 
            this.lbFail.AutoSize = true;
            this.lbFail.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFail.ForeColor = System.Drawing.Color.White;
            this.lbFail.Location = new System.Drawing.Point(375, 181);
            this.lbFail.Name = "lbFail";
            this.lbFail.Size = new System.Drawing.Size(54, 27);
            this.lbFail.TabIndex = 11;
            this.lbFail.Text = "Fail:";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.White;
            this.lbPass.Location = new System.Drawing.Point(375, 113);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(61, 27);
            this.lbPass.TabIndex = 10;
            this.lbPass.Text = "Pass:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(372, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "Static by Result";
            // 
            // listViewAVG
            // 
            this.listViewAVG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAVG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listViewAVG.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAVG.FullRowSelect = true;
            this.listViewAVG.GridLines = true;
            this.listViewAVG.Location = new System.Drawing.Point(21, 51);
            this.listViewAVG.Name = "listViewAVG";
            this.listViewAVG.Size = new System.Drawing.Size(327, 325);
            this.listViewAVG.TabIndex = 12;
            this.listViewAVG.UseCompatibleStateImageBehavior = false;
            // 
            // StaticResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(661, 388);
            this.Controls.Add(this.listViewAVG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFail);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.label3);
            this.Name = "StaticResult";
            this.Text = "StaticResult";
            this.Load += new System.EventHandler(this.StaticResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFail;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewAVG;
    }
}