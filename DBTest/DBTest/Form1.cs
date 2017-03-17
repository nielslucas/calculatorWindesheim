using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTest
{
    public partial class Form1 : Form
    {

        private WindesheimEntities _db = new WindesheimEntities();

        public Form1()
        {
            InitializeComponent();

        }
        
         private void LBCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectcourse = LBCourses.SelectedItem.ToString();

            var courses = from course in _db.Courses
                         where course.Title == selectcourse
                         select course;
           var selectedcourse = courses.First();
            LBStudents.Items.Clear();
            foreach(Student student in selectedcourse.Students)
            {
                LBStudents.Items.Add((student.FirstName + " " + student.lastName));
            }
            if (selectedcourse.Teacher != null) { 
            TBTeacher.Text = (selectedcourse.Teacher.FirstName + " " + selectedcourse.Teacher.LastName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //course.Title = "aah";
            //course.TeacherID = 1;
            //db.Courses.Add(course);

            foreach (Cours course in _db.Courses)
            {
                LBCourses.Items.Add(course.Title);
            }
            Dictionary<int, string> teachers = new Dictionary<int, string>();
                       foreach(var teacher in _db.Teachers)
            {
                teachers.Add(teacher.ID, teacher.FirstName);
            }
            CBTeachers.DataSource = new BindingSource(teachers, null);
            CBTeachers.ValueMember = "key";
            CBTeachers.DisplayMember = "value";
            
        }

        private void LBStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BAddcourse_Click(object sender, EventArgs e)
        {
            Cours course = new Cours();
            var selectedteacher =_db.Teachers.Find(CBTeachers.SelectedItem);
            course.TeacherID = selectedteacher.ID;
            course.Title= TBAddCourse.Text;
            _db.Courses.Add(course);
            _db.SaveChanges();
            LBCourses.Items.Clear();
           LBCourses.Items.Add(_db.Courses.Last().Title);
           

        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            string studentname = TBSearchStudents.Text;

            var students = from student in _db.Students
                           where student.FirstName.Contains(studentname)|
                           student.lastName.Contains(studentname)
                           select student;
            
            LBStudents.Items.Clear();
            foreach(Student student in students)
            {
                LBStudents.Items.Add(student.FirstName + " " + student.lastName);
            }

        }
    }
}
