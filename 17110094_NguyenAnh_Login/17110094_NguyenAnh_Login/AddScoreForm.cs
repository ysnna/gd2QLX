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
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_DESKTOP_RRRHOP4DataSet4.Score' table. You can move, or remove it, as needed.
            this.scoreTableAdapter.Fill(this._DESKTOP_RRRHOP4DataSet4.Score);
            reloadDGVScoreData();
            SqlCommand cmds = new SqlCommand("select * from score");
            dgvScore.DataSource = score.getAllScore(cmds);
        }
        SCORE score = new SCORE();
        Course course = new Course();
        MY_DB mydb = new MY_DB();
        void reloadDGVScoreData()
        {
            SqlCommand cmdc = new SqlCommand("select * from course");
            ComboBoxSelectCourse.DataSource = course.getAllCourse(cmdc);
            ComboBoxSelectCourse.DisplayMember = "label";
            ComboBoxSelectCourse.ValueMember = "id";
            ComboBoxSelectCourse.SelectedItem = null;
            //TextBoxStudentID.Text = "";
            //TextBoxScore.Text = "";
            //TextBoxDescription.Text = "";
        }
        private void ButtonAddScore_Click(object sender, EventArgs e)
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
            //String.Format("{0:0.##}", score_student);
            string description = TextBoxDescription.Text;
            if (score.insertScore(studentID, scoreID, score_student, description))
            {
                MessageBox.Show("New Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddScoreForm_Load(sender, e);
            }
        }
    }
}