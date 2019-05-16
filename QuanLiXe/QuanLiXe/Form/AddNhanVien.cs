using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLiXe
{
    public partial class AddNhanVien : Form
    {
        public AddNhanVien()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        private void ptbAva_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                ptbAva.Image = Image.FromFile(open.FileName);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string sdt = txtSdt.Text;
            string gender = "male";
            if (radioFemale.Checked)
            {
                gender = "female";
            }
            DateTime bdate = dateTimePicker1.Value;
            string address = txtAddress.Text;
            string cmnd = txtCmnd.Text;
            string type = "part time";
            if (radioFull.Checked)
            {
                gender = "full time";
            }

            MemoryStream pic = new MemoryStream();
            ptbAva.Image.Save(pic, ptbAva.Image.RawFormat);
            if (nv.insertNhanVien(manv, ho, ten, gender, bdate, sdt, address, cmnd, pic, type))
            {
                MessageBox.Show("oke!");
            }
        }
    }
}