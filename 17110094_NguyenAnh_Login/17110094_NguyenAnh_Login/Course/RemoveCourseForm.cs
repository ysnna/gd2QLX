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
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        private void btAddCourse_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtRemove.Text);
            if (course.deleteCourse(id))
            {
                MessageBox.Show("Course deleted");
            }
            else
            {
                MessageBox.Show("This course does not exist");
            }
        }
    }
}