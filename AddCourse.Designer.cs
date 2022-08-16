
namespace Student_Management_System
{
    partial class AddCourse
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_addcourse = new System.Windows.Forms.Button();
            this.button_clearcourse = new System.Windows.Forms.Button();
            this.textBox_coursedes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_coursedur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_coursename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView_courses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_courses)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Add Course";
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
            this.panel1.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.button_addcourse);
            this.panel4.Controls.Add(this.button_clearcourse);
            this.panel4.Controls.Add(this.textBox_coursedes);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textbox_coursedur);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.textbox_coursename);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 270);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1134, 341);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1134, 58);
            this.panel3.TabIndex = 58;
            // 
            // button_addcourse
            // 
            this.button_addcourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_addcourse.BackColor = System.Drawing.Color.LightGray;
            this.button_addcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addcourse.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addcourse.ForeColor = System.Drawing.Color.DimGray;
            this.button_addcourse.Location = new System.Drawing.Point(936, 242);
            this.button_addcourse.Name = "button_addcourse";
            this.button_addcourse.Size = new System.Drawing.Size(75, 28);
            this.button_addcourse.TabIndex = 57;
            this.button_addcourse.Text = "Add";
            this.button_addcourse.UseVisualStyleBackColor = false;
            this.button_addcourse.Click += new System.EventHandler(this.button_addcourse_Click);
            // 
            // button_clearcourse
            // 
            this.button_clearcourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clearcourse.BackColor = System.Drawing.Color.NavajoWhite;
            this.button_clearcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clearcourse.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clearcourse.ForeColor = System.Drawing.Color.DimGray;
            this.button_clearcourse.Location = new System.Drawing.Point(855, 242);
            this.button_clearcourse.Name = "button_clearcourse";
            this.button_clearcourse.Size = new System.Drawing.Size(75, 28);
            this.button_clearcourse.TabIndex = 54;
            this.button_clearcourse.Text = "Clear";
            this.button_clearcourse.UseVisualStyleBackColor = false;
            this.button_clearcourse.Click += new System.EventHandler(this.button_clearcourse_Click);
            // 
            // textBox_coursedes
            // 
            this.textBox_coursedes.Font = new System.Drawing.Font("Gadugi", 12F);
            this.textBox_coursedes.Location = new System.Drawing.Point(199, 144);
            this.textBox_coursedes.Multiline = true;
            this.textBox_coursedes.Name = "textBox_coursedes";
            this.textBox_coursedes.Size = new System.Drawing.Size(401, 127);
            this.textBox_coursedes.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(92, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "Description:";
            // 
            // textbox_coursedur
            // 
            this.textbox_coursedur.Font = new System.Drawing.Font("Gadugi", 12F);
            this.textbox_coursedur.Location = new System.Drawing.Point(199, 83);
            this.textbox_coursedur.Name = "textbox_coursedur";
            this.textbox_coursedur.Size = new System.Drawing.Size(182, 29);
            this.textbox_coursedur.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(112, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Duration:";
            // 
            // textbox_coursename
            // 
            this.textbox_coursename.Font = new System.Drawing.Font("Gadugi", 12F);
            this.textbox_coursename.Location = new System.Drawing.Point(199, 22);
            this.textbox_coursename.Name = "textbox_coursename";
            this.textbox_coursename.Size = new System.Drawing.Size(182, 29);
            this.textbox_coursename.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(78, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Course Name:";
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
            this.DataGridView_courses.Location = new System.Drawing.Point(12, 52);
            this.DataGridView_courses.Name = "DataGridView_courses";
            this.DataGridView_courses.RowHeadersVisible = false;
            this.DataGridView_courses.RowHeadersWidth = 20;
            this.DataGridView_courses.RowTemplate.Height = 80;
            this.DataGridView_courses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_courses.Size = new System.Drawing.Size(1110, 212);
            this.DataGridView_courses.TabIndex = 25;
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(12, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 11);
            this.panel2.TabIndex = 27;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.DataGridView_courses);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_courses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_courses;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_coursedes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_coursedur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_coursename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_addcourse;
        private System.Windows.Forms.Button button_clearcourse;
    }
}