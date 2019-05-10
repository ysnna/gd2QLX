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
    public partial class SelectContactForm : Form
    {
        public SelectContactForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        private void SelectContactForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_DESKTOP_RRRHOP4SelectContact.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this._DESKTOP_RRRHOP4SelectContact.Contact);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("select fname, lname, group_id, userid from contact", mydb.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            DataGridView1.DataSource = table;
        }
    }
}