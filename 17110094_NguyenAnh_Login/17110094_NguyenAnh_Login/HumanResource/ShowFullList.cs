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

namespace _17110094_NguyenAnh_Login
{
    public partial class ShowFullList : Form
    {
        public ShowFullList()
        {
            InitializeComponent();
        }
        CONTACT contact = new CONTACT();
        private void ShowFullList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetShowAll.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.datasetShowAll.Contact);
            int uid = GlobalID.IDGlobal;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 90; //chỉnh pic đẹp
            DataGridView1.Width = 4500;
            DataGridView1.DataSource = contact.GetContactById(uid);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridView1.AllowUserToAddRows = false;

            //DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //DataGridView1.RowTemplate.Height = 80;
            //CONTACT ct = new CONTACT();
            //SqlCommand cmd = new SqlCommand("select fname as 'First Name',lname as'Last Name', grouptable.name as'Group',phone,email,address,pic" +
            //    "from Contact INNER JOIN Grouptable on Contact.group_id = Grouptable.id where Contact.userid=@userid");
            //cmd.Parameters.Add("@userid", SqlDbType.Int).Value = GlobalID.IDGlobal;
            //DataGridView1.DataSource = ct.SelectContactList(cmd);
            //picCol = (DataGridViewImageColumn)DataGridView1.Columns[6];
            //picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //for (int i = 0; i < DataGridView1.Rows.Count; i++)
            //{
            //    if (IsOdd(i))
            //    {
            //        DataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            //    }
            //}
            MyGroup gr = new MyGroup();
            
            ListBoxCourse.DataSource = gr.getGroups(GlobalID.IDGlobal);
            ListBoxCourse.DisplayMember = "name";
            ListBoxCourse.ValueMember = "id";
            ListBoxCourse.SelectedItem = null;
            DataGridView1.ClearSelection();
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}