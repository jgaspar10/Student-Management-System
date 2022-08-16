
namespace Student_Management_System
{
    partial class ManageCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_deletecourse = new System.Windows.Forms.Button();
            this.textBox_courseID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_updatecourse = new System.Windows.Forms.Button();
            this.button_clearcourse = new System.Windows.Forms.Button();
            this.textBox_coursedes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_coursedur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_coursename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGridView_courses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_courses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.button_deletecourse);
            this.panel4.Controls.Add(this.textBox_courseID);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.button_updatecourse);
            this.panel4.Controls.Add(this.button_clearcourse);
            this.panel4.Controls.Add(this.textBox_coursedes);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textbox_coursedur);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.textbox_coursename);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 316);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1133, 295);
            this.panel4.TabIndex = 28;
            // 
            // button_deletecourse
            // 
            this.button_deletecourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_deletecourse.BackColor = System.Drawing.Color.Tomato;
            this.button_deletecourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deletecourse.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deletecourse.ForeColor = System.Drawing.Color.DimGray;
            this.button_deletecourse.Location = new System.Drawing.Point(797, 177);
            this.button_deletecourse.Name = "button_deletecourse";
            this.button_deletecourse.Size = new System.Drawing.Size(75, 28);
            this.button_deletecourse.TabIndex = 61;
            this.button_deletecourse.Text = "Delete";
            this.button_deletecourse.UseVisualStyleBackColor = false;
            this.button_deletecourse.Click += new System.EventHandler(this.button_deletecourse_Click);
            // 
            // textBox_courseID
            // 
            this.textBox_courseID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_courseID.Font = new System.Drawing.Font("Gadugi", 12F);
            this.textBox_courseID.Location = new System.Drawing.Point(141, 22);
            this.textBox_courseID.Name = "textBox_courseID";
            this.textBox_courseID.Size = new System.Drawing.Size(154, 29);
            this.textBox_courseID.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(49, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 59;
            this.label3.Text = "Course ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1133, 58);
            this.panel3.TabIndex = 58;
            // 
            // button_updatecourse
            // 
            this.button_updatecourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_updatecourse.BackColor = System.Drawing.Color.YellowGreen;
            this.button_updatecourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updatecourse.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updatecourse.ForeColor = System.Drawing.Color.DimGray;
            this.button_updatecourse.Location = new System.Drawing.Point(714, 177);
            this.button_updatecourse.Name = "button_updatecourse";
            this.button_updatecourse.Size = new System.Drawing.Size(75, 28);
            this.button_updatecourse.TabIndex = 57;
            this.button_updatecourse.Text = "Update";
            this.button_updatecourse.UseVisualStyleBackColor = false;
            this.button_updatecourse.Click += new System.EventHandler(this.button_updatecourse_Click);
            // 
            // button_clearcourse
            // 
            this.button_clearcourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_clearcourse.BackColor = System.Drawing.Color.NavajoWhite;
            this.button_clearcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clearcourse.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clearcourse.ForeColor = System.Drawing.Color.DimGray;
            this.button_clearcourse.Location = new System.Drawing.Point(633, 177);
            this.button_clearcourse.Name = "button_clearcourse";
            this.button_clearcourse.Size = new System.Drawing.Size(75, 28);
            this.button_clearcourse.TabIndex = 54;
            this.button_clearcourse.Text = "Clear";
            this.button_clearcourse.UseVisualStyleBackColor = false;
            this.button_clearcourse.Click += new System.EventHandler(this.button_clearcourse_Click);
            // 
            // textBox_coursedes
            // 
            this.textBox_coursedes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_coursedes.Font = new System.Drawing.Font("Gadugi", 12F);
            this.textBox_coursedes.Location = new System.Drawing.Point(141, 78);
            this.textBox_coursedes.Multiline = true;
            this.textBox_coursedes.Name = "textBox_coursedes";
            this.textBox_coursedes.Size = new System.Drawing.Size(401, 127);
            this.textBox_coursedes.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(34, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "Description:";
            // 
            // textbox_coursedur
            // 
            this.textbox_coursedur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textbox_coursedur.Font = new System.Drawing.Font("Gadugi", 12F);
            this.textbox_coursedur.Location = new System.Drawing.Point(744, 22);
            this.textbox_coursedur.Name = "textbox_coursedur";
            this.textbox_coursedur.Size = new System.Drawing.Size(182, 29);
            this.textbox_coursedur.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(631, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Duration (h):";
            // 
            // textbox_coursename
            // 
            this.textbox_coursename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textbox_coursename.Font = new System.Drawing.Font("Gadugi", 12F);
            this.textbox_coursename.Location = new System.Drawing.Point(432, 22);
            this.textbox_coursename.Name = "textbox_coursename";
            this.textbox_coursename.Size = new System.Drawing.Size(182, 29);
            this.textbox_coursename.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(311, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Course Name:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Course Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 46);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(12, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 11);
            this.panel2.TabIndex = 40;
            // 
            // DataGridView_courses
            // 
            this.DataGridView_courses.AllowUserToAddRows = false;
            this.DataGridView_courses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_courses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_courses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_courses.BackgroundColor = System.Drawing.Color.DimGray;
            this.DataGridView_courses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_courses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_courses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_courses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_courses.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_courses.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_courses.EnableHeadersVisualStyles = false;
            this.DataGridView_courses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_courses.Location = new System.Drawing.Point(12, 85);
            this.DataGridView_courses.Name = "DataGridView_courses";
            this.DataGridView_courses.RowHeadersVisible = false;
            this.DataGridView_courses.RowHeadersWidth = 20;
            this.DataGridView_courses.RowTemplate.Height = 80;
            this.DataGridView_courses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_courses.Size = new System.Drawing.Size(1110, 212);
            this.DataGridView_courses.TabIndex = 29;
            this.DataGridView_courses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_courses.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_courses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_courses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_courses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_courses.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.DataGridView_courses.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_courses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_courses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_courses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_courses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_courses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_courses.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_courses.ThemeStyle.ReadOnly = false;
            this.DataGridView_courses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_courses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_courses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_courses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_courses.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_courses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_courses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_courses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_student_CellContentClick);
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.Font = new System.Drawing.Font("Gadugi", 12F);
            this.textBox_search.Location = new System.Drawing.Point(859, 51);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(182, 29);
            this.textBox_search.TabIndex = 65;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.DimGray;
            this.button_search.Location = new System.Drawing.Point(1047, 52);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 28);
            this.button_search.TabIndex = 66;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DataGridView_courses);
            this.Name = "ManageCourseForm";
            this.Text = "ManagaeCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_updatecourse;
        private System.Windows.Forms.Button button_clearcourse;
        private System.Windows.Forms.TextBox textBox_coursedes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_coursedur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_coursename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_courses;
        private System.Windows.Forms.Button button_deletecourse;
        private System.Windows.Forms.TextBox textBox_courseID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
    }
}