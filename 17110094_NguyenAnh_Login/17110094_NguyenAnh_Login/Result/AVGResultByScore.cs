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
            try
            {
                SqlCommand clearrecord = new SqlCommand("Delete from Result", mydb.getConnection);
                mydb.openConnection();
                clearrecord.ExecuteNonQuery();
                SCORE score = new SCORE();
                SqlCommand command = new SqlCommand("select *  from Course order by label", mydb.getConnection);
                DataTable table = new DataTable();
                table.Load(command.ExecuteReader());
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    SqlCommand deleteCol = new SqlCommand("alter table Result drop column if exists" + "[" + table.Rows[i]["Label"].ToString() + "]", mydb.getConnection);
                    deleteCol.ExecuteNonQuery();
                    SqlCommand command1 = new SqlCommand("ALTER TABLE Result add " + "[" + table.Rows[i]["Label"].ToString() + "]" + " float", mydb.getConnection);
                    command1.ExecuteNonQuery();
                }
                SqlCommand deleteCol1 = new SqlCommand("alter table Result drop column if exists" + "[Average Score]", mydb.getConnection);
                deleteCol1.ExecuteNonQuery();
                SqlCommand deleteCol2 = new SqlCommand("alter table Result drop column if exists" + "[Result]", mydb.getConnection);
                deleteCol2.ExecuteNonQuery();
                SqlCommand addAvg = new SqlCommand("Alter table Result Add [Average Score] float", mydb.getConnection);
                addAvg.ExecuteNonQuery();
                SqlCommand addRe = new SqlCommand("Alter table Result Add [Result] nvarchar(50)", mydb.getConnection);
                addRe.ExecuteNonQuery();
                SqlCommand lenh = new SqlCommand("Select * from std", mydb.getConnection);
                DataTable table1 = new DataTable();
                table1.Load(lenh.ExecuteReader());
                foreach (DataRow row in table1.Rows)
                {
                    float tong = 0, trungbinh;
                    int id = Int32.Parse(row["ID"].ToString());
                    DataTable diem = score.getScoreById(id);
                    SqlCommand command3 = new SqlCommand("INSERT into Result(student_ID,fname,lname) VALUES(@id,@fn,@ln)", mydb.getConnection);
                    command3.Parameters.Add("@id", SqlDbType.NChar).Value = row["ID"].ToString();
                    command3.Parameters.Add("@fn", SqlDbType.NChar).Value = row["fname"].ToString();
                    command3.Parameters.Add("@ln", SqlDbType.NChar).Value = row["lname"].ToString();
                    command3.ExecuteNonQuery();

                    for (int i = 0; i < table.Rows.Count; i++)
                    {

                        SqlCommand command2 = new SqlCommand("Update Result Set " + "[" + table.Rows[i]["Label"].ToString() + "]" + " = @value where Student_ID = " + row["ID"].ToString(), mydb.getConnection);
                        command2.Parameters.Add("@value", SqlDbType.Float).Value = float.Parse(diem.Rows[i]["Student_Score"].ToString());
                        //command2.Parameters.Add("@label",SqlDbType.NVarChar).Value = diem
                        command2.ExecuteNonQuery();
                        tong += float.Parse(diem.Rows[i]["Student_Score"].ToString());
                    }
                    trungbinh = tong / table.Rows.Count;
                    SqlCommand insertAvg = new SqlCommand("Update Result set [Average Score] = " + trungbinh + "where Student_ID = " + row["ID"].ToString(), mydb.getConnection);
                    insertAvg.ExecuteNonQuery();
                    if (trungbinh >= 5)
                    {
                        SqlCommand insertRe = new SqlCommand("Update Result set [Result] = N'Passed'" + "where Student_ID = " + row["ID"].ToString(), mydb.getConnection);
                        insertRe.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand insertRe = new SqlCommand("Update Result set [Result] = N'Failed'" + "where Student_ID = " + row["ID"].ToString(), mydb.getConnection);
                        insertRe.ExecuteNonQuery();
                    }
                }

                mydb.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand command4 = new SqlCommand("Select * from Result", mydb.getConnection);
            DataTable table4 = new DataTable();
            mydb.openConnection();
            table4.Load(command4.ExecuteReader());
            dgvResult.DataSource = table4;
            mydb.closeConnection();
            dgvResult.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvResult.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            #region nháp
            //DataTable dt = score.getResultByScore();
            //DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            //id.HeaderText = "Student ID";
            //DataGridViewTextBoxColumn fn = new DataGridViewTextBoxColumn();
            //fn.HeaderText = "First name";
            //DataGridViewTextBoxColumn ln = new DataGridViewTextBoxColumn();
            //ln.HeaderText = "Last name";
            //DataGridViewTextBoxColumn avg = new DataGridViewTextBoxColumn();
            //avg.HeaderText = "Average Grade";
            //DataGridViewTextBoxColumn rs = new DataGridViewTextBoxColumn();
            //rs.HeaderText = "Result";
            //dgvResult.Columns.Add(id);
            //dgvResult.Columns.Add(fn);
            //dgvResult.Columns.Add(ln);
            //SqlCommand cmd = new SqlCommand("select label from course");

            //int x = dt.Rows.Count;
            //int i = 0;
            //foreach (DataRow row in dt.Rows)
            //{
            //    // dgvResult.Items.Add(row["label"].ToString());
            //    dt.Rows[i][1] = Convert.ToString(Math.Round(Convert.ToDouble(dt.Rows[i]["averageGrade"].ToString()), 2));
            //    //listViewAVG.Items[i].SubItems.Add(row["averageGrade"].ToString());
            //    i++;
            //}
            #endregion
        }
        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentID.Text = dgvResult.CurrentRow.Cells[0].Value.ToString();
            TextBoxFname.Text = dgvResult.CurrentRow.Cells[1].Value.ToString();
            TextBoxLname.Text = dgvResult.CurrentRow.Cells[2].Value.ToString();
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Result where CONCAT(Student_ID,fname) LIKE'%" + txtSearch.Text + "%'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvResult.DataSource = table;
        }
        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            int height = dgvResult.Height;
            dgvResult.Height = dgvResult.RowCount * dgvResult.RowTemplate.Height * 2;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.dgvResult.Width * 2, this.dgvResult.Height);
            dgvResult.DrawToBitmap(bmp, new Rectangle(0, 0, dgvResult.Width, dgvResult.Height));
            dgvResult.Height = height;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}