namespace _17110094_NguyenAnh_Login
{
    partial class AVGScoreByCourseForm
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
            this.listViewAVG = new System.Windows.Forms.ListView();
            this.SuspendLayout();
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
            this.listViewAVG.Location = new System.Drawing.Point(12, 12);
            this.listViewAVG.Name = "listViewAVG";
            this.listViewAVG.Size = new System.Drawing.Size(373, 325);
            this.listViewAVG.TabIndex = 0;
            this.listViewAVG.UseCompatibleStateImageBehavior = false;
            // 
            // AVGScoreByCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 349);
            this.Controls.Add(this.listViewAVG);
            this.Name = "AVGScoreByCourseForm";
            this.Text = "AVGScoreByCourseForm";
            this.Load += new System.EventHandler(this.AVGScoreByCourseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAVG;
    }
}