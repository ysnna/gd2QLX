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
    public partial class ManageCoursesForm : Form
    {
        public ManageCoursesForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        int pos;
        private void ManageCoursesForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
        void reloadListBoxData()
        {
            SqlCommand cmd = new SqlCommand("select * from course");
            ListBoxCourse.DataSource = course.getAllCourse(cmd);
            ListBoxCourse.ValueMember = "id";
            ListBoxCourse.DisplayMember = "label";
            ListBoxCourse.SelectedItem = null;
            LabelTotalCourses.Text = "Total courses: " + course.totalCourse();
        }
        void showData(int index)
        {
            SqlCommand cmd = new SqlCommand("select * from course");
            DataRow dr = course.getAllCourse(cmd).Rows[index];
            ListBoxCourse.SelectedIndex = index;
            TextBoxID.Text = dr.ItemArray[0].ToString();
            TextBoxCourseName.Text = dr.ItemArray[1].ToString();
            NumericUpDownHours.Value = int.Parse(dr.ItemArray[2].ToString());
            TextBoxDesciption.Text = dr.ItemArray[3].ToString();
        }

        private void ListBoxCourse_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)ListBoxCourse.SelectedItem;
            pos = ListBoxCourse.SelectedIndex;
            showData(pos);
        }

        private void ButonAddCourse_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBoxID.Text);
            string lable = TextBoxCourseName.Text;
            int period = (int)NumericUpDownHours.Value;
            string description = TextBoxDesciption.Text;
            if (lable.Trim() == "")
            {
                MessageBox.Show("Add a course name", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (course.checkCourseName(lable))
            {
                if (course.insertCourse(id, lable, period, description))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
                }
                else MessageBox.Show("Course not inserted.", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("This course name already exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBoxID.Text);
            string name = TextBoxCourseName.Text;
            int hrs = (int)NumericUpDownHours.Value;
            string description = TextBoxDesciption.Text;
            //kiểm tra tồn tại và trùng
            if(!course.checkCourseName(name,Convert.ToInt32(TextBoxID.Text)))
            {
                MessageBox.Show("This course name already exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(course.updateCourse(id,name,hrs,description))
            {
                MessageBox.Show("Course updated", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadListBoxData();
            }
            else
            {
                MessageBox.Show("Course not updated", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pos = 0;
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int courseID = Convert.ToInt32(TextBoxID.Text);
                if(MessageBox.Show("Are you sure you want to delete this course?","Remove course",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if(course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course deleted", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TextBoxID.Text = "";
                        TextBoxCourseName.Text = "";
                        NumericUpDownHours.Value = 10;
                        TextBoxDesciption.Text = "";
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course not deleted", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter a valid numeric ID", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from course");
            if (pos <(course.getAllCourse(cmd).Rows.Count -1))
            {
                pos++;
                showData(pos);
            }
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if(pos>0)
            {
                pos--;
                showData(pos);
            }
        }

        private void ButtonLast_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from course");
            pos = course.getAllCourse(cmd).Rows.Count - 1;
            showData(pos);
        }
    }
}