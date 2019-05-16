using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QuanLiXe.UserControls
{
    public partial class TongDoanThuUC : UserControl
    {
        DoanhThu dthu = new DoanhThu();
        public TongDoanThuUC()
        {
            InitializeComponent();
        }
        //Load tong doanh thu
        private void TongDoanThuUC_Load(object sender, EventArgs e)
        {
            dgvThongKe.RowTemplate.Height = 70;
            dgvThongKe.DataSource = dthu.getThongKe();
            dgvThongKe.Columns[0].HeaderText = "Loại xe";
            dgvThongKe.Columns[1].HeaderText = "Ngày";
            dgvThongKe.Columns[2].HeaderText = "Số lượng";
            dgvThongKe.Columns[3].HeaderText = "Tổng tiền";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = Convert.ToDateTime(dateTimePicker.Text);
            DataTable dt = dthu.getDoanhThu(Convert.ToDateTime(dateTimePicker.Text));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string loaixe = dt.Rows[i][0].ToString();
                int soluong = Convert.ToInt32(dt.Rows[i][2]);
                int tongtien = Convert.ToInt32(dt.Rows[i][3]);
                if (dthu.search(today, loaixe) == false)
                {
                    dthu.insertDoanhThu(loaixe, today, soluong, tongtien);
                }
                else
                {
                    dthu.updateDoanhThu(soluong, tongtien, loaixe);
                }
            }
            dgvThongKe.DataSource = dthu.getThongKe();
        }
    }
}