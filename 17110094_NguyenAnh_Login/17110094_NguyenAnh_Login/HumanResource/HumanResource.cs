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
    public partial class HumanResource : Form
    {
        public HumanResource()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        CONTACT contact = new CONTACT();
        private void HumanResource_Load(object sender, EventArgs e)
        {
            getImageAndUser();
            reloadremoveGroup();
        }
        void reloadremoveGroup()
        {
            SqlCommand cmdc = new SqlCommand("select * from Grouptable", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmdc);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cbRemoveG.DataSource = tb;
            cbRemoveG.DisplayMember = "name";
            cbRemoveG.ValueMember = "id";
            cbRemoveG.SelectedItem = null;
            cbEditG.DataSource = tb;
            cbEditG.DisplayMember = "name";
            cbEditG.ValueMember = "id";
            cbEditG.SelectedItem = null;
        }
        public void getImageAndUser()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select *from Login where Id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = GlobalID.IDGlobal;
            da.SelectCommand = cmd;
            da.Fill(dt);
            if ((dt.Rows.Count > 0))
            {
                byte[] pic = (byte[])dt.Rows[0]["figure"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
                labelUser.Text = "Welcome ( " + dt.Rows[0]["username"].ToString() + " )";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddContact add = new AddContact();
            add.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.ShowDialog();
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            ShowFullList show = new ShowFullList();
            show.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectContactForm sl = new SelectContactForm();
            sl.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            contact.deleteContact(Convert.ToInt32(TextBoxID.Text));
            MessageBox.Show("Deleted");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        MyGroup myGroup = new MyGroup();
        private void btnRemoveG_Click(object sender, EventArgs e)
        {
            int id = (int)cbRemoveG.SelectedValue;
            myGroup.deleteGroup(id);
            MessageBox.Show("Deleted");
            reloadremoveGroup();
        }

        private void btnEditG_Click(object sender, EventArgs e)
        {
            int id = (int)cbEditG.SelectedValue;
            myGroup.updateGroup(id, txtEditG.Text);
            MessageBox.Show("Edited");
            reloadremoveGroup();
        }

        private void btnAddG_Click(object sender, EventArgs e)
        {
            if (!myGroup.groupExist(txtAddG.Text, "add", GlobalID.IDGlobal))
            {
                myGroup.insertGroup(Convert.ToInt32(txtIDGroup.Text), txtAddG.Text, GlobalID.IDGlobal);

                MessageBox.Show("Group Added");
                reloadremoveGroup();
            }
            else MessageBox.Show("roor");
        }
    }
}