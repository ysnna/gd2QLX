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

namespace QuanLiXe
{
    public partial class BaiXeForm : Form
    {
        public BaiXeForm()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        KhachHang kh = new KhachHang();
        public void BaiXeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_DESKTOP_RRRHOP4DataSet1.BAIXE' table. You can move, or remove it, as needed.
            this.bAIXETableAdapter.Fill(this._DESKTOP_RRRHOP4DataSet1.BAIXE);

            connectionBaiXe();
        }
        void connectionBaiXe()
        {
            
            SqlCommand cmd = new SqlCommand("select * from BAIXE", db.getConnection);
            dgvBaiXe.DataSource = kh.getCus(cmd);
        }
        private void btBackThoat_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            this.Close();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            connectionBaiXe();
        }
    }
}