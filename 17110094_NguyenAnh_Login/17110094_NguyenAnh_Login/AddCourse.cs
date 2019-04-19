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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void btAddCourse_Click(object sender, EventArgs e)
        {
            Course cou = new Course();
            int id = Convert.ToInt32(txtCourseId.Text);
            string lable = txtLabel.Text;
            int period = Convert.ToInt32(txtPeriod.Text);
            string description = txtDescription.Text;


            if (lable.Trim() == "")
            {
                MessageBox.Show("Add a course name", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (period < 10) MessageBox.Show("Period >= 10", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cou.checkCourseName(lable))
            {
                if (cou.insertCourse(id, lable, period, description))
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Course not inserted.", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("This course name already exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            bool verif()
            {
                if ((txtCourseId.Text.Trim() == "")
                    || (txtLabel.Text.Trim() == "")
                    || (txtDescription.Text.Trim() == "")
                    || (txtPeriod.Text.Trim() == "")
                   )
                    return false;
                return true;
            }
        }
    }
}