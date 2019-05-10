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
using System.Drawing.Printing;

namespace _17110094_NguyenAnh_Login
{
    public partial class PrintStudentForm : Form
    {
        public PrintStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();
        private void Print_Load(object sender, EventArgs e)
        {
            DateTimePic1.CustomFormat = "yyyy-dd-MM";
            DateTimePic1.Format = DateTimePickerFormat.Custom;
            DateTimePick2.CustomFormat = "yyyy-dd-MM";
            DateTimePick2.Format = DateTimePickerFormat.Custom;

            SqlCommand cmd = new SqlCommand("select * from Std");
            fillGrid(cmd);
            if(NoRad.Checked)
            {
                DateTimePic1.Enabled = false;
                DateTimePick2.Enabled = false;
            }
        }

        public void fillGrid(SqlCommand cmd)
        {
            DataGridView1.ReadOnly = true;
            //xử lí hình ảnh, code có tham khảo msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 90; //chỉnh pic đẹp
            DataGridView1.Width = 4500;
            DataGridView1.DataSource = student.getStudents(cmd);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridView1.AllowUserToAddRows = false;
        }



        private void CheckBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            string query;
            if(YesRad.Checked)
            {
                string date1 = DateTimePic1.Value.ToString("yyyy-MM-dd");
                string date2 = DateTimePick2.Value.ToString("yyyy-MM-dd");
                if(radioButtonMale.Checked)
                {
                    query = "select * from std where gender = 'Male' and bdate between '" + date1 + " 'and' " + date2 + "'";
                }
                else if(radioButtonFemale.Checked)
                {
                    query = "select * from std where gender = 'Female' and bdate between '" + date1 + " 'and' " + date2 + "'";
                }
                else
                {
                    query = "select * from std where bdate between '" + date1 + " 'and' " + date2 + "'";
                }
                cmd = new SqlCommand(query);
                fillGrid(cmd);
            }
            else
            {
                if (radioButtonMale.Checked)
                {
                    query = "select * from std where gender = 'Male'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "select * from std where gender = 'Female'";
                }
                else query = "select * from std";
                cmd = new SqlCommand(query);
                fillGrid(cmd);
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void SaveFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Text File|*.txt";
                var result = dialog.ShowDialog();
                if (result != DialogResult.OK)
                    return;
                StringBuilder builder = new StringBuilder();
                int rowcount = DataGridView1.Rows.Count;
                int columncount = DataGridView1.Columns.Count;
                builder.AppendLine("Student ID   \tFirst Name  \tLast Name  \tDate of Birth        \tGender  \tPhone    \tAddress   ");
                builder.AppendLine("----------------------------------------------------------------------------------------------------------------------");
                for (int i = 0; i < rowcount; i++)
                {
                    List<string> cols = new List<string>();
                    for (int j = 0; j < columncount - 1; j++)
                    {
                        cols.Add(DataGridView1.Rows[i].Cells[j].Value.ToString());
                    }
                    builder.AppendLine(string.Join("\t", cols.ToArray()));
                }
                System.IO.File.WriteAllText(dialog.FileName, builder.ToString());
                MessageBox.Show(@"Text file was created.");
            }
            catch (FileLoadException fe) { fe.Message.ToString(); }
        }

        private void YesRad_CheckedChanged(object sender, EventArgs e)
        {
            DateTimePic1.Enabled = true;
            DateTimePick2.Enabled = true;
        }

        private void NoRad_CheckedChanged(object sender, EventArgs e)
        {
            DateTimePic1.Enabled = false;
            DateTimePick2.Enabled = false;
        }
    }
}