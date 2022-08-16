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
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
    public partial class ManageCourseForm : Form
    {
        CourseClass course = new CourseClass();
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            showTable();

        }
        // show  course data
        private void showTable()
        {
            DataGridView_courses.DataSource = course.GetCourse(new MySqlCommand("SELECT * FROM `courses`"));

        }

        private void button_clearcourse_Click(object sender, EventArgs e)
        {
            textBox_courseID.Clear();
            textbox_coursename.Clear();
            textbox_coursedur.Clear();
            textBox_coursedes.Clear();
        }

        private void button_updatecourse_Click(object sender, EventArgs e)
        {
            if (textbox_coursename.Text == "" || textbox_coursedur.Text == "" || textBox_courseID.Text.Equals(""))
            {
                MessageBox.Show("Please Insert Course Details", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_courseID.Text);
                string Cname = textbox_coursename.Text;
                int dur = Convert.ToInt32(textbox_coursedur.Text);
                string desc = textBox_coursedes.Text;

                if (course.UpdateCourse(id, Cname, dur, desc))
                {
                    showTable();
                    button_clearcourse.PerformClick();
                    MessageBox.Show("Course Updated Succefully", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error Updating Course", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_deletecourse_Click(object sender, EventArgs e)
        {
            if (textBox_courseID.Text.Equals(""))
            {
                MessageBox.Show("Please Insert Course ID", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_courseID.Text);
                    string Cname = textbox_coursename.Text;
                    int dur = Convert.ToInt32(textbox_coursedur.Text);
                    string desc = textBox_coursedes.Text;

                    if (course.deleteCourse(id))
                    {
                        showTable();
                        button_clearcourse.PerformClick();
                        MessageBox.Show("Course Deleted Succefully", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }catch(Exception ex)

                {
                    MessageBox.Show(ex.Message, "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_courseID.Text = DataGridView_courses.CurrentRow.Cells[0].Value.ToString();
            textbox_coursename.Text = DataGridView_courses.CurrentRow.Cells[1].Value.ToString();
            textbox_coursedur.Text = DataGridView_courses.CurrentRow.Cells[2].Value.ToString();
            textBox_coursedes.Text = DataGridView_courses.CurrentRow.Cells[3].Value.ToString();

        }

        private void button_search_Click(object sender, EventArgs e)
        {

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
