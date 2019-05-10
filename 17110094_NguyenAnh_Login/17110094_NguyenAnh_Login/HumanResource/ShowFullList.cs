using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17110094_NguyenAnh_Login
{
    public partial class ShowFullList : Form
    {
        public ShowFullList()
        {
            InitializeComponent();
        }

        private void ShowFullList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetShowAll.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.datasetShowAll.Contact);

        }
    }
}
