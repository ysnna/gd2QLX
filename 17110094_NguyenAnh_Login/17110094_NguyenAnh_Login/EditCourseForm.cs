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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from course");
            ComboBoxCourse.DataSource = course.getAllCourse(cmd);
            ComboBoxCourse.DisplayMember = "label";
            ComboBoxCourse.ValueMember = "id";
            ComboBoxCourse.SelectedItem = null;
        }
        public void fillCombo(int index)
        {
            SqlCommand cmd = new SqlCommand("select * from course");
            ComboBoxCourse.DataSource = course.getAllCourse(cmd);
            ComboBoxCourse.DisplayMember = "label";
            ComboBoxCourse.ValueMember = "id";
            ComboBoxCourse.SelectedIndex = index;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            int hrs = (int)NumericUpDownHours.Value;
            string descr = TextBoxDescription.Text;
            int id = (int)ComboBoxCourse.SelectedValue;
            if (!course.checkCourseName(name, Convert.ToInt32(ComboBoxCourse.SelectedValue)))
            {
                MessageBox.Show("This is course naem already exist", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, name, hrs, descr))
            {
                MessageBox.Show("Course updated", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombo(ComboBoxCourse.SelectedIndex);
            }
            else MessageBox.Show("Course not updated", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ComboBoxCourse_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ComboBoxCourse.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                TextBoxName.Text = table.Rows[0][1].ToString();
                NumericUpDownHours.Value = Int32.Parse(table.Rows[0][2].ToString());
                TextBoxDescription.Text = table.Rows[0][3].ToString();
            }
            catch { }
        }
    }
}