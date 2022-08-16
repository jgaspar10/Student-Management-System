using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
    public partial class AddCourse : Form
    {
        CourseClass course = new CourseClass();
        public AddCourse()
        {
            InitializeComponent();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            // to show course list
            showTable();

        }
        private void showTable()
        {
            DataGridView_courses.DataSource = course.GetCourse(new MySqlCommand("SELECT * FROM `courses`"));

        }


        private void button_addcourse_Click(object sender, EventArgs e)
        {
            if (textbox_coursename.Text == "" || textbox_coursedur.Text == "")
            {
                showTable();
                MessageBox.Show("Please Insert Course Deatails", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string Cname = textbox_coursename.Text;
                int dur = Convert.ToInt32(textbox_coursedur.Text);
                string desc = textBox_coursedes.Text;

                if (course.InsertCourse(Cname, dur, desc))
                {
                    button_clearcourse.PerformClick();
                    MessageBox.Show("New Course Added Succefully", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error Adding Course", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_clearcourse_Click(object sender, EventArgs e)
        {
            textbox_coursename.Clear();
            textbox_coursedur.Clear();
            textBox_coursedes.Clear();

        }



        private void DataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textbox_coursename.Text = DataGridView_courses.CurrentRow.Cells[1].Value.ToString();
            textbox_coursedur.Text = DataGridView_courses.CurrentRow.Cells[2].Value.ToString();
            textBox_coursedes.Text = DataGridView_courses.CurrentRow.Cells[2].Value.ToString();
        }


    }
}
