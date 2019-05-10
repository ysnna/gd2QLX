﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuAddNewStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm add = new AddStudentForm();
            add.Show(this);
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsListForm std = new studentsListForm();
            std.Show(this);
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentForm f = new ManageStudentForm();
            f.ShowDialog(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm fStatic = new StaticForm();
            fStatic.ShowDialog(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentForm fP = new PrintStudentForm();
            fP.ShowDialog(this);
        }

        private void addCourseToolStripMenu_Click(object sender, EventArgs e)
        {
            AddCourse add = new AddCourse();
            add.ShowDialog(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm rm = new RemoveCourseForm();
            rm.ShowDialog(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm edit = new EditCourseForm();
            edit.ShowDialog(this);
        }

        private void manageCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCoursesForm manage = new ManageCoursesForm();
            manage.ShowDialog(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm p = new PrintCourseForm();
            p.ShowDialog(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm add = new AddScoreForm();
            add.ShowDialog(this);
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AVGScoreByCourseForm avg = new AVGScoreByCourseForm();
            avg.ShowDialog(this);
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AVGResultByScore avg = new AVGResultByScore();
            avg.ShowDialog(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveForm result = new RemoveForm();
            result.ShowDialog(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm m = new ManageScoreForm();
            m.ShowDialog(this);
        }

        private void aVGResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AVGResultByScore f = new AVGResultByScore();
            f.ShowDialog();
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRemoveForm edit = new EditRemoveForm();
            edit.ShowDialog();
        }
    }
}