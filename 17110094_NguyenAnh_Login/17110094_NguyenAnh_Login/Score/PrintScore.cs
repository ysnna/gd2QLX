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
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace _17110094_NguyenAnh_Login
{
    public partial class PrintScore : Form
    {
        public PrintScore()
        {
            InitializeComponent();
        }

        private void ButtonSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Text File|*.txt";
                var result = dialog.ShowDialog();
                if (result != DialogResult.OK)
                    return;
                StringBuilder builder = new StringBuilder();
                int rowcount = dgvManageScore.Rows.Count;
                int columncount = dgvManageScore.Columns.Count;
                builder.AppendLine("ID   \tLabel\tPeriod \tDescription             ");
                builder.AppendLine("----------------------------------------");
                for (int i = 0; i < rowcount; i++)
                {
                    List<string> cols = new List<string>();
                    for (int j = 0; j < columncount; j++)
                    {
                        cols.Add(dgvManageScore.Rows[i].Cells[j].Value.ToString());
                    }
                    builder.AppendLine(string.Join("\t", cols.ToArray()));
                }
                System.IO.File.WriteAllText(dialog.FileName, builder.ToString());
                MessageBox.Show(@"Text file was created.");
            }
            catch (FileLoadException fe) { fe.Message.ToString(); }
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }
        SCORE score = new SCORE();
        MY_DB mydb = new MY_DB();
        private void PrintScore_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from score", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dgvManageScore.DataSource = table;
        }
    }
}