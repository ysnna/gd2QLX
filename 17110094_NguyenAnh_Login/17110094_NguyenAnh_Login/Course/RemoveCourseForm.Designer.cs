﻿namespace _17110094_NguyenAnh_Login
{
    partial class RemoveCourseForm
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
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.btAddCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter The Course ID:";
            // 
            // txtRemove
            // 
            this.txtRemove.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemove.Location = new System.Drawing.Point(45, 67);
            this.txtRemove.Multiline = true;
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(303, 42);
            this.txtRemove.TabIndex = 2;
            // 
            // btAddCourse
            // 
            this.btAddCourse.BackColor = System.Drawing.Color.MediumBlue;
            this.btAddCourse.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAddCourse.Location = new System.Drawing.Point(354, 67);
            this.btAddCourse.Name = "btAddCourse";
            this.btAddCourse.Size = new System.Drawing.Size(132, 42);
            this.btAddCourse.TabIndex = 10;
            this.btAddCourse.Text = "Remove";
            this.btAddCourse.UseVisualStyleBackColor = false;
            this.btAddCourse.Click += new System.EventHandler(this.btAddCourse_Click);
            // 
            // RemoveCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(531, 156);
            this.Controls.Add(this.btAddCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRemove);
            this.Name = "RemoveCourseForm";
            this.Text = "RemoveCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Button btAddCourse;
    }
}