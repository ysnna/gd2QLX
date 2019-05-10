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
    public partial class StaticResult : Form
    {
        public StaticResult()
        {
            InitializeComponent();
        }
        Course course = new Course();
        SCORE score = new SCORE();
        MY_DB mydb = new MY_DB();
        private void StaticResult_Load(object sender, EventArgs e)
        {
            listViewAVG.Items.Clear();
            DataTable dt = score.getAvgScoreByCourse();
            listViewAVG.View = View.Details;
            listViewAVG.Columns.Add("Course", 160);
            listViewAVG.Columns.Add("Average Grade", 160);
            //listViewAVG.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //listViewAVG.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewAVG.GridLines = true;
            listViewAVG.FullRowSelect = true;
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                listViewAVG.Items.Add(row["label"].ToString());
                dt.Rows[i][1] = Convert.ToString(Math.Round(Convert.ToDouble(dt.Rows[i]["averageGrade"].ToString()), 2));
                listViewAVG.Items[i].SubItems.Add(row["averageGrade"].ToString());
                i++;
            }

            SqlCommand cmd = new SqlCommand("select * from Result ", mydb.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(table);
            int count = table.Rows.Count;
            int countPass = 0;
            for (int j = 0; j < count; i++)
            {
                if (table.Rows[j]["result"].ToString().Trim() == "Passed")
                    countPass++;
            }
            float perPass = (countPass * 100) / count;
            float perFail = 100 - perPass;
            lbPass.Text = "Pass: " + perPass + " %";
            lbFail.Text = "Fail: " + perFail + " %";
        }
    }
}