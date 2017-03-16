namespace DBTest
{
    partial class Form1
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
            this.LBCourses = new System.Windows.Forms.ListBox();
            this.LBStudents = new System.Windows.Forms.ListBox();
            this.TBTeacher = new System.Windows.Forms.TextBox();
            this.TBAddCourse = new System.Windows.Forms.TextBox();
            this.BAddcourse = new System.Windows.Forms.Button();
            this.CBTeachers = new System.Windows.Forms.ComboBox();
            this.TBSearchStudents = new System.Windows.Forms.TextBox();
            this.BSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBCourses
            // 
            this.LBCourses.FormattingEnabled = true;
            this.LBCourses.Location = new System.Drawing.Point(12, 12);
            this.LBCourses.Name = "LBCourses";
            this.LBCourses.Size = new System.Drawing.Size(120, 95);
            this.LBCourses.TabIndex = 0;
            this.LBCourses.SelectedIndexChanged += new System.EventHandler(this.LBCourses_SelectedIndexChanged);
            // 
            // LBStudents
            // 
            this.LBStudents.FormattingEnabled = true;
            this.LBStudents.Location = new System.Drawing.Point(138, 39);
            this.LBStudents.Name = "LBStudents";
            this.LBStudents.Size = new System.Drawing.Size(120, 95);
            this.LBStudents.TabIndex = 1;
            this.LBStudents.SelectedIndexChanged += new System.EventHandler(this.LBStudents_SelectedIndexChanged);
            // 
            // TBTeacher
            // 
            this.TBTeacher.Location = new System.Drawing.Point(138, 13);
            this.TBTeacher.Name = "TBTeacher";
            this.TBTeacher.Size = new System.Drawing.Size(100, 20);
            this.TBTeacher.TabIndex = 2;
            // 
            // TBAddCourse
            // 
            this.TBAddCourse.Location = new System.Drawing.Point(264, 12);
            this.TBAddCourse.Name = "TBAddCourse";
            this.TBAddCourse.Size = new System.Drawing.Size(100, 20);
            this.TBAddCourse.TabIndex = 3;
            // 
            // BAddcourse
            // 
            this.BAddcourse.Location = new System.Drawing.Point(370, 9);
            this.BAddcourse.Name = "BAddcourse";
            this.BAddcourse.Size = new System.Drawing.Size(75, 23);
            this.BAddcourse.TabIndex = 4;
            this.BAddcourse.Text = "add course";
            this.BAddcourse.UseVisualStyleBackColor = true;
            this.BAddcourse.Click += new System.EventHandler(this.BAddcourse_Click);
            // 
            // CBTeachers
            // 
            this.CBTeachers.FormattingEnabled = true;
            this.CBTeachers.Location = new System.Drawing.Point(265, 39);
            this.CBTeachers.Name = "CBTeachers";
            this.CBTeachers.Size = new System.Drawing.Size(121, 21);
            this.CBTeachers.TabIndex = 5;
            // 
            // TBSearchStudents
            // 
            this.TBSearchStudents.Location = new System.Drawing.Point(138, 150);
            this.TBSearchStudents.Name = "TBSearchStudents";
            this.TBSearchStudents.Size = new System.Drawing.Size(100, 20);
            this.TBSearchStudents.TabIndex = 6;
            // 
            // BSearch
            // 
            this.BSearch.Location = new System.Drawing.Point(244, 148);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(75, 23);
            this.BSearch.TabIndex = 7;
            this.BSearch.Text = "search students";
            this.BSearch.UseVisualStyleBackColor = true;
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 261);
            this.Controls.Add(this.BSearch);
            this.Controls.Add(this.TBSearchStudents);
            this.Controls.Add(this.CBTeachers);
            this.Controls.Add(this.BAddcourse);
            this.Controls.Add(this.TBAddCourse);
            this.Controls.Add(this.TBTeacher);
            this.Controls.Add(this.LBStudents);
            this.Controls.Add(this.LBCourses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBCourses;
        private System.Windows.Forms.ListBox LBStudents;
        private System.Windows.Forms.TextBox TBTeacher;
        private System.Windows.Forms.TextBox TBAddCourse;
        private System.Windows.Forms.Button BAddcourse;
        private System.Windows.Forms.ComboBox CBTeachers;
        private System.Windows.Forms.TextBox TBSearchStudents;
        private System.Windows.Forms.Button BSearch;
    }
}

