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
            lbxedapHour.Location = new Point(918, 486);
            lbxemayHour.Location = new Point(1110, 486);
            lbotoHour.Location = new Point(1302, 486);
            lbxedapDay.Location = new Point(918, 560);
            lbxemayDay.Location = new Point(1110, 560);
            lbotoDay.Location = new Point(1302, 560);
            lbxedapWeek.Location = new Point(918, 634);
            lbxemayWeek.Location = new Point(1110, 634);
            lbotoWeek.Location = new Point(1302, 634);
            lbXedapMonth.Location = new Point(918, 708);
            lbxemayMonth.Location = new Point(1110, 708);
            lbotoMonth.Location = new Point(1302, 708);
        }

        private void pictureBoxOption_Click(object sender, EventArgs e)
        {
            FormChinhGia f = new FormChinhGia();
            f.ShowDialog();
        }
    }
}