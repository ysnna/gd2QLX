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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void ButtonEditStudent_Click(object sender, EventArgs e)
        {
            HMR hm = new HMR();
            int id = Convert.ToInt32(txtStudentID.Text);
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;

            int groupid = Convert.ToInt32(txtGroupID.Text);
            string phone = TextBoxPhone.Text;
            string address = TextBoxAddress.Text;
            string email = txtEmail.Text;
            MemoryStream pic = new MemoryStream();
            PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
            if (hm.updateContact(fname, lname, groupid, phone, email, address, pic, id))
            {

                MessageBox.Show("Student edited", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Error", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                PictureBoxStudentImage.Image = Image.FromFile(open.FileName);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSelectContact_Click(object sender, EventArgs e)
        {
            SelectContactForm sl = new SelectContactForm();
            sl.ShowDialog();
        }
    }
}