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
    public partial class AVGResultByScore : Form
    {
        MY_DB mydb = new MY_DB();
        SCORE score = new SCORE();
        Course course = new Course();
        public AVGResultByScore()
        {
            InitializeComponent();
        }

        private void AVGResultByScore_Load(object sender, EventArgs e)
        {
            DataTable dt = score.getResultByScore();
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "Student ID";
            DataGridViewTextBoxColumn fn = new DataGridViewTextBoxColumn();
            fn.HeaderText = "First name";
            DataGridViewTextBoxColumn ln = new DataGridViewTextBoxColumn();
            ln.HeaderText = "Last name";
            DataGridViewTextBoxColumn avg = new DataGridViewTextBoxColumn();
            avg.HeaderText = "Average Grade";
            DataGridViewTextBoxColumn rs = new DataGridViewTextBoxColumn();
            rs.HeaderText = "Result";
            dgvResult.Columns.Add(id);
            dgvResult.Columns.Add(fn);
            dgvResult.Columns.Add(ln);
            SqlCommand cmd = new SqlCommand("select label from course");

            int x = dt.Rows.Count;
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                // dgvResult.Items.Add(row["label"].ToString());
                dt.Rows[i][1] = Convert.ToString(Math.Round(Convert.ToDouble(dt.Rows[i]["averageGrade"].ToString()), 2));
                //listViewAVG.Items[i].SubItems.Add(row["averageGrade"].ToString());
                i++;
            }
        }
    }
}