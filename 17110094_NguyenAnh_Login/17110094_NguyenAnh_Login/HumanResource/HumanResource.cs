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
        private void HumanResource_Load(object sender, EventArgs e)
        {
            getImageAndUser();
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
    }
}