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
    public partial class RemoveForm : Form
    {
        public RemoveForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void ResultForm_Load(object sender, EventArgs e)
        {
            //DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            //id.HeaderText = "Student ID";
            //DataGridViewTextBoxColumn fn = new DataGridViewTextBoxColumn();
            //fn.HeaderText = "First name";
            //DataGridViewTextBoxColumn ln = new DataGridViewTextBoxColumn();
            //ln.HeaderText = "Last name";
            //DataGridViewTextBoxColumn cid = new DataGridViewTextBoxColumn();
            //cid.HeaderText = "Course ID";
            //DataGridViewTextBoxColumn lb = new DataGridViewTextBoxColumn();
            //lb.HeaderText = "Label";
            //DataGridViewTextBoxColumn sc = new DataGridViewTextBoxColumn();
            //sc.HeaderText = "Student score";
            //dgvRemove.Columns.Add(id);
            //dgvRemove.Columns.Add(fn);
            //dgvRemove.Columns.Add(ln);
            //dgvRemove.Columns.Add(cid);
            //dgvRemove.Columns.Add(lb);
            //dgvRemove.Columns.Add(sc);
            //DataTable dt = score.getRemove();
            //int i = 0;
            //foreach (DataRow row in dt.Rows)
            //{
            //    dgvRemove.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            //    i++;
            //}
            dgvRemove.DataSource = score.getRemove();
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            int sID = dgvRemove.CurrentCell.RowIndex;
            int studentID = Convert.ToInt32(dgvRemove.Rows[sID].Cells[0].Value);
            int courseID = Convert.ToInt32(dgvRemove.Rows[sID].Cells[3].Value);
            if (MessageBox.Show("Are you sure you want to delete this student?", "Delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (score.deleteScore(studentID, courseID))
                {
                    MessageBox.Show("Student deleted", " Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvRemove.DataSource = score.getRemove();
                }
                else
                {
                    MessageBox.Show("Student not deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}