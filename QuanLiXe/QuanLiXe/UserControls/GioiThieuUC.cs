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
    public partial class GioiThieuUC : UserControl
    {
        public GioiThieuUC()
        {
            InitializeComponent();
        }

        private void GioiThieuUC_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(120, -78);
        }
    }
}