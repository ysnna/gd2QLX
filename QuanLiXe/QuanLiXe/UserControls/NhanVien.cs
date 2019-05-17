using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLiXe.UserControls
{
    public partial class NhanVien1 : UserControl
    {
        public NhanVien1()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvNhanVien.ReadOnly = true;
            string manv = txtSearch.Text;
            //xử lí hình ảnh, code có tham khảo msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvNhanVien.RowTemplate.Height = 90; //chỉnh pic đẹp
            dgvNhanVien.DataSource = nv.searchNhanVien(manv);
            picCol = (DataGridViewImageColumn)dgvNhanVien.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvNhanVien.AllowUserToAddRows = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNhanVien ad = new AddNhanVien();
            ad.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            #region
            //string manv = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            //manv = manv.Trim();
            //Global.MANV(manv);
            //string fname = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            //fname = fname.Trim();
            //Global.FNAME(fname);
            //string lname = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            //lname = lname.Trim();
            //Global.LNAME(lname);
            //string gender = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            //gender = gender.Trim();
            //Global.gender(gender);

            //Edit ed = new Edit();
            //byte[] pic;
            //pic = (byte[])dgvNhanVien.CurrentRow.Cells[8].Value;
            //MemoryStream picture = new MemoryStream(pic);
            //Global.pic = Image.FromStream(picture);
            //string phone = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            //phone = phone.Trim();
            //Global.PHONE(phone);
            //string address = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            //address = address.Trim();
            //Global.ADDRESS(address);
            //string cmnd = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
            //cmnd = cmnd.Trim();
            //Global.CMND(cmnd);
            //string type = dgvNhanVien.CurrentRow.Cells[9].Value.ToString();
            //type = type.Trim();
            //Global.TYPE(type);
            #endregion
            //DateTime BDAY= (DateTime)dgvNhanVien.CurrentRow.Cells[4].Value;
            //Global.Birthday(BDAY);
            //byte[] pic;
            //pic = (byte[])dgvNhanVien.CurrentRow.Cells[7].Value;
            //ed.ShowDialog();
            Edit ed = new Edit();
            ed.txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            ed.txtMaNV.Text = ed.txtMaNV.Text.Trim();
            ed.txtHo.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            ed.txtTen.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dgvNhanVien.CurrentRow.Cells[3].Value.ToString().Trim();
            if (dgvNhanVien.CurrentRow.Cells[3].Value.ToString() == "male")
            {
                ed.radioMale.Checked = true;
            }
            else
            {
                ed.radioFemale.Checked = true;
            }
            ed.dtpBirthday.Value = (DateTime)dgvNhanVien.CurrentRow.Cells[4].Value;
            ed.txtSdt.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            ed.txtAddress.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            ed.txtCmnd.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
            dgvNhanVien.CurrentRow.Cells[9].Value = dgvNhanVien.CurrentRow.Cells[9].Value.ToString().Trim();
            if (dgvNhanVien.CurrentRow.Cells[9].Value.ToString() == "Giam Sat")
            {
                ed.radioGS.Checked = true;
            }
            else if (dgvNhanVien.CurrentRow.Cells[9].Value.ToString() == "Van Phong")
            {
                ed.radioVP.Checked = true;
            }
            else
            {
                ed.radioTho.Checked = true;
            }
            byte[] pic;
            pic = (byte[])dgvNhanVien.CurrentRow.Cells[8].Value;
            MemoryStream picture = new MemoryStream(pic);
            ed.ptbAva.Image = Image.FromStream(picture);


            ed.ShowDialog();
        }

        private void btnThongKeNV_Click(object sender, EventArgs e)
        {
            ThongKeNV nv = new ThongKeNV();
            nv.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string manv = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            manv = manv.Trim();
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa nhân viên có mã " + manv, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dlr == DialogResult.Yes)
            {
                dgvNhanVien.DataSource = nv.DeleteNhanVien(manv);
                MessageBox.Show("Nhân viên có mã " + manv + "đã bị xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvNhanVien.DataSource = nv.getAllNV();
            dgvNhanVien.Show();
            dgvNhanVien.RowTemplate.Height = 90;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvNhanVien.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        public void refresh()
        {
            dgvNhanVien.DataSource = nv.getAllNV();
            dgvNhanVien.Show();
            dgvNhanVien.RowTemplate.Height = 90;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvNhanVien.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private void NhanVien1_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nv.getAllNV();
            dgvNhanVien.Show();
            dgvNhanVien.RowTemplate.Height = 90;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvNhanVien.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            Global.MANV(id);
        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvNhanVien.DataSource = nv.getAllNV();
            dgvNhanVien.Show();
            dgvNhanVien.RowTemplate.Height = 90;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvNhanVien.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
    }
}