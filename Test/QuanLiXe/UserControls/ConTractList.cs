using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiXe.UserControls
{
    public partial class HopDongGui : UserControl
    {
        public HopDongGui()
        {
            InitializeComponent();
        }

        private void HopDongGui_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCon_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.ShowDialog();
        }
    }
}