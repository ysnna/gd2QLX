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