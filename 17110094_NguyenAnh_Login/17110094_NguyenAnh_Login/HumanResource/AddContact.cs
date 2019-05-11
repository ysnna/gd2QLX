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
        CONTACT contact = new CONTACT();
        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtStudentID.Text);
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            int groupid = (int)comboGroup.SelectedValue;
            string phone = TextBoxPhone.Text;
            string address = TextBoxAddress.Text;
            string email = txtEmail.Text;
            int uid = GlobalID.IDGlobal;
            MemoryStream pic = new MemoryStream();
            PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
            if (contact.insertContact(id, fname, lname, phone, address, email, uid, groupid, pic))
            {
                MessageBox.Show("New contact added", "Add contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Error", "Add contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void AddContact_Load(object sender, EventArgs e)
        {
            reloadDGVScoreData();
        }
    }
}