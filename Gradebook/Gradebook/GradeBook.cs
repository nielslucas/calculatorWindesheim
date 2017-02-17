using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class GradeBook

    {
        int total;
        int GradeCounter;

        public string CourseName { get; set; }


        public GradeBook(string courseName)
        {
            CourseName = courseName;
        }
        public string DisplayMessage()
        {
            string message = "welcome to the grade book\n" + CourseName;
            return message;
        }
        public List<double> DetermineClassAverage(int grade)
        {
            List<double> Grades = new List<double>();

            total += grade;
            GradeCounter++;
            int Average = total / GradeCounter;
            Grades.Add(Average);
            Grades.Add(total);

            return Grades;

            

        }
        //public List<double> InputNumbers()
        //{

        //}


    }
}
