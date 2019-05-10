using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _17110094_NguyenAnh_Login
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        UserRegister user = new UserRegister();
        void CreateControls()
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.IsBalloon = true;
            ToolTip1.AutoPopDelay = 5000;
            ToolTip1.InitialDelay = 600;

            ToolTip1.ReshowDelay = 500;
            ToolTip1.ToolTipIcon = ToolTipIcon.Info;
            ToolTip1.ToolTipTitle = "Login";
            ToolTip1.SetToolTip(this.txtUsername, "Nhap ky tu");
            ToolTip1.SetToolTip(this.txtPassword, "Nhap ky tu");
        }
        void CreateErrorProvider()
        {
            ErrorProvider error = new ErrorProvider();
            error.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            TextBox txt = new TextBox();
            txt.Name = "txtUsername";
            //error.SetError(txt, "Blank is not valid");
            this.Controls.Add(txt);
        }
        ErrorProvider errorProvider = new ErrorProvider();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string userreg = txtUsername.Text;
            string pass = txtPassword.Text;
            MemoryStream pic = new MemoryStream();
            if (verif())
            {
                PictureBoxProfileImage.Image.Save(pic, PictureBoxProfileImage.Image.RawFormat);
                if (user.usernameExist(id, userreg) == true)
                {
                    if (user.insertUser(id, fname, lname, userreg, pass, pic))
                    {
                        MessageBox.Show("Registration Completed Succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This Username or ID Already Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Empty fields", "Register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtUsername_Validated(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                errorProvider.SetError(this.txtUsername, "");
            }
            else
            {
                errorProvider.SetError(this.txtUsername, "Password is required");
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            CreateControls();
        }
        bool verif()
        {
            if ((txtID.Text.Trim() == "")
                || (txtFname.Text.Trim() == "")
                || (txtLname.Text.Trim() == "")
                || (txtUsername.Text.Trim() == "")
                || (PictureBoxProfileImage.Image == null))
                return false;
            return true;
        }
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                PictureBoxProfileImage.Image = Image.FromFile(open.FileName);
        }
    }
}