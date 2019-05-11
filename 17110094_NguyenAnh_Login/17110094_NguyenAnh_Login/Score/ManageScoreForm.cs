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

namespace _17110094_NguyenAnh_Login
{
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        MY_DB mydb = new MY_DB();
        Course course = new Course();
        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            dgvManageScore.BringToFront();
            reloadDGVScoreData();
            dgvManageScore.DataSource = score.getRemove();
            dgvManageScore.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        void refreshDGV()
        {
            
        }
        void reloadDGVScoreData()
        {
            SqlCommand cmdc = new SqlCommand("select * from course");
            ComboBoxSelectCourse.DataSource = course.getAllCourse(cmdc);
            ComboBoxSelectCourse.DisplayMember = "label";
            ComboBoxSelectCourse.ValueMember = "id";
            ComboBoxSelectCourse.SelectedItem = null;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(TextBoxStudentID.Text);
            int row = 0;
            SqlCommand cmd = new SqlCommand("select * from course", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString() == ComboBoxSelectCourse.Text)
                {
                    row = Convert.ToInt32(dt.Rows[i][0].ToString());
                    break;
                }
            }
            mydb.closeConnection();
            int scoreID = row;
            float score_student = float.Parse(Convert.ToString(Math.Round(Convert.ToDouble(TextBoxScore.Text), 2)));
            string description = TextBoxDescription.Text;
            if (score.insertScore(studentID, scoreID, score_student, description))
            {
                MessageBox.Show("New Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // dgvManageScore.Update();
                dgvManageScore.Refresh();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int sID = dgvManageScore.CurrentCell.RowIndex;
            int studentID = Convert.ToInt32(dgvManageScore.Rows[sID].Cells[0].Value);
            int courseID = Convert.ToInt32(dgvManageScore.Rows[sID].Cells[3].Value);
            if (MessageBox.Show("Are you sure you want to delete this student?", "Delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (score.deleteScore(studentID, courseID))
                {
                    MessageBox.Show("Student deleted", " Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvManageScore.DataSource = score.getRemove();
                }
                else
                {
                    MessageBox.Show("Student not deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAVG_Click(object sender, EventArgs e)
        {
            AVGScoreByCourseForm avg = new AVGScoreByCourseForm();
            avg.ShowDialog();
        }

        private void showStudent_Click(object sender, EventArgs e)
        {
            dgvShowStudent.BringToFront();
            dgvShowStudent.DataSource = score.getShowStudent();
            dgvShowStudent.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void showScore_Click(object sender, EventArgs e)
        {
            dgvManageScore.DataSource = score.getRemove();
            dgvManageScore.BringToFront();
            dgvManageScore.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}