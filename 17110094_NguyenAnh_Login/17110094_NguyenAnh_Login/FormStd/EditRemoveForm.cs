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
using System.IO;

namespace _17110094_NguyenAnh_Login
{
    public partial class EditRemoveForm : Form
    {
        public EditRemoveForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        STUDENT student = new STUDENT();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from std where Concat(id,fname, lname, address) like'%" + txtSearch.Text + "%'");
            dgvStudent.ReadOnly = true;
            //xử lí hình ảnh, code có tham khảo msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvStudent.RowTemplate.Height = 90; //chỉnh pic đẹp
            dgvStudent.DataSource = student.getStudents(cmd);
            picCol = (DataGridViewImageColumn)dgvStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvStudent.AllowUserToAddRows = false;
        }

        private void EditRemoveForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetEditRemoveStudent.Std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.dataSetEditRemoveStudent.Std);
            this.Controls.Add(dgvStudent);
            dgvStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgvStudent.RowHeadersVisible = false;
            SqlCommand cmd = new SqlCommand("select * from Std");
            dgvStudent.ReadOnly = true;
            //xử lí hình ảnh, code có tham khảo msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            this.dgvStudent.DefaultCellStyle.Font = new Font("Arial", 15);
            dgvStudent.RowTemplate.Height = 90;
            dgvStudent.DataSource = student.getStudents(cmd);
            picCol = (DataGridViewImageColumn)dgvStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvStudent.AllowUserToAddRows = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            updateDeletStdF updateDeleteStdF = new updateDeletStdF();
            //thứ tự của các cột trong table
            updateDeleteStdF.TextBoxID.Text = dgvStudent.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStdF.TextBoxFname.Text = dgvStudent.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStdF.TextBoxLname.Text = dgvStudent.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStdF.DateTimePicker1.Value = (DateTime)dgvStudent.CurrentRow.Cells[3].Value;
            if (dgvStudent.CurrentRow.Cells[4].Value.ToString().Trim() == "Female")
                updateDeleteStdF.RadioButtonFemale.Checked = true;
            updateDeleteStdF.TextBoxPhone.Text = dgvStudent.CurrentRow.Cells[5].Value.ToString();
            updateDeleteStdF.TextBoxAddress.Text = dgvStudent.CurrentRow.Cells[6].Value.ToString();
            //úp ảnh lên, hơi lâu
            byte[] pic;
            pic = (byte[])dgvStudent.CurrentRow.Cells[7].Value;

            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStdF.PictureBoxStudentImage.Image = Image.FromStream(picture);
            updateDeleteStdF.Show();
            //this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int current = dgvStudent.CurrentCell.RowIndex;
            int ID = Convert.ToInt32(dgvStudent.Rows[current].Cells[0].Value);


            if (MessageBox.Show("Are you want to delete this", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                student.deleteStudent(ID);
            }
            MessageBox.Show("Deleted");
            SqlCommand cmd = new SqlCommand("select * from Std");
            dgvStudent.DataSource = student.getStudents(cmd);
            try
            {

            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\LTWindows\WindowsQLXe\QLXe\gd2QLX\17110094_NguyenAnh_Login\17110094_NguyenAnh_Login\DESKTOP-RRRHOP4.mdf;Integrated Security=True;Connect Timeout=30");
        //SqlDataAdapter daSV = null;
        //DataTable dtSV = null;
        private void btnSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //if (conn.State == ConnectionState.Open) conn.Close();
            //conn.Open();
            try
            {
                int id = Convert.ToInt32(txtSearch.Text);
                SqlCommand cmd = new SqlCommand("select * from Std where id like N'%" + id + "%'", mydb.getConnection);
                dgvStudent.DataSource = student.SearchStudentFName(cmd);
            }
            catch (Exception E)
            {

            }
        }
    }
}