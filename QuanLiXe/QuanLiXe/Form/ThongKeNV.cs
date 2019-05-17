using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiXe
{
    public partial class ThongKeNV : Form
    {
        public ThongKeNV()
        {
            InitializeComponent();
        }

        private void ptbBack_Click(object sender, EventArgs e)
        {
            ptbTho.Visible = true;
            ptbVanPhong.Visible = true;
            ptbGiamSat.Visible = true;
            dgvTho.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label1.BringToFront();
            label2.BringToFront();
            label3.BringToFront();
        }
        NhanVien nv = new NhanVien();
        private void ptbTho_Click(object sender, EventArgs e)
        {
            ptbGiamSat.Visible = false;
            ptbVanPhong.Visible = false;
            ptbTho.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            dgvTho.RowTemplate.Height = 90;
            dgvTho.DataSource = nv.getAllTho();
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvTho.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvTho.Show();
        }

        private void ptbVanPhong_Click(object sender, EventArgs e)
        {
            ptbGiamSat.Visible = false;
            ptbVanPhong.Visible = false;
            ptbTho.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            dgvTho.DataSource = nv.getAllVanPhong();
            dgvTho.RowTemplate.Height = 90;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvTho.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvTho.Show();
        }

        private void ptbGiamSat_Click(object sender, EventArgs e)
        {
            ptbGiamSat.Visible = false;
            ptbVanPhong.Visible = false;
            ptbTho.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            dgvTho.DataSource = nv.getAllGS();
            dgvTho.RowTemplate.Height = 90;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvTho.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvTho.Show();
        }
    }
}