using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace _17110094_NguyenAnh_Login
{
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }
        UserRegister user = new UserRegister();
        HMR hm = new HMR();
        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtStudentID.Text);
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            int groupid = Convert.ToInt32(comboGroup.Text);
            string phone = TextBoxPhone.Text;
            string address = TextBoxAddress.Text;
            string email = txtEmail.Text;
            //int 
            MemoryStream pic = new MemoryStream();
            PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
            if (hm.insertContact(fname, lname, groupid, phone, email, address, pic, id))
            {
                MessageBox.Show("New contact added", "Add contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Error", "Add contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}