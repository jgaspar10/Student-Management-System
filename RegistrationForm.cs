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

namespace Student_Management_System
{
    public partial class RegistrationForm : Form
    {
        StudentClass student = new StudentClass();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            // Upload Photo
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                picturebox_student.Image = Image.FromFile(opf.FileName);
        }


        private void button_add_Click_1(object sender, EventArgs e)
        {
            // Add New Student
            string fname = textbox_Fname.Text;
            string lname = textbox_Lname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textbox_contactnum.Text;
            string address = textBox_address.Text;
            string gender = radioButton_Male.Checked ? "Male":"Female";

            // Now to get photo from picture box
            MemoryStream ms = new MemoryStream();
            picturebox_student.Image.Save(ms, picturebox_student.Image.RawFormat);
            byte[] img = ms.ToArray();

            // Check student age is between 10 to 100
            int year_born = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if((this_year-year_born)<10  || (this_year - year_born) > 100)
            {
                MessageBox.Show("Student age must be between 10 and 100", "Invalid Date of Birth",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    if (student.insertStudent(fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("New Student Added", "Add New Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } catch(Exception ex)
               
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add student details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // Creating a funtion to verify
        bool verify()
        {
            if((textbox_Fname.Text=="")||(textbox_Lname.Text=="") ||
                (textbox_contactnum.Text=="") ||(textBox_address.Text=="") ||
                (picturebox_student.Image==null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            showTable();
        }
        // To show student list in DataGridVIEW
        public void showTable()
        {
            DataGridView_student.DataSource = student.getStudentlist();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            // Clear Information
            textbox_Fname.Clear();
            textbox_Lname.Clear();
            textbox_contactnum.Clear();
            textBox_address.Clear();
            radioButton_Male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            picturebox_student.Image = null;
        }

    }
}
