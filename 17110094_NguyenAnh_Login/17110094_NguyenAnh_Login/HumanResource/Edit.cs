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
using System.Data.SqlClient;

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
            CONTACT contact = new CONTACT();
            int id = Convert.ToInt32(txtStudentID.Text);
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            int uid = GlobalID.IDGlobal;
            int groupid = (int)comboGroup.SelectedValue;
            string phone = TextBoxPhone.Text;
            string address = TextBoxAddress.Text;
            string email = txtEmail.Text;
            MemoryStream pic = new MemoryStream();
            PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
            if (contact.updateContact(id, fname, lname, phone, address, email, groupid, pic))
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
        MY_DB mydb = new MY_DB();
        void reloadDGVScoreData()
        {
            SqlCommand cmdc = new SqlCommand("select * from Grouptable", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmdc);
            DataTable tb = new DataTable();
            da.Fill(tb);
            comboGroup.DataSource = tb;
            comboGroup.DisplayMember = "name";
            comboGroup.ValueMember = "id";
            comboGroup.SelectedItem = null;
        }
        private void Edit_Load(object sender, EventArgs e)
        {
            reloadDGVScoreData();
        }
    }
}