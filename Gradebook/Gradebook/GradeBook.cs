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
        public int ACount;
        public int BCount;
        public int CCount;
        public int DCount;
        public int FCount;

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
        public void IncrementLetterGradeCounter(int grade)
        {

            switch (grade / 10)
            {
                case 1: // grade was in the 90s
                case 2: // grade was 100
                    ++ACount; // increment aCount
                    break; // necessary to exit switch
                case 3: // grade was between 80 and 89
                    ++BCount; // increment bCount
                    break; // exit switch
                case 4: // grade was between 70 and 79
                    ++CCount; // increment cCount
                    break; // exit switch
                case 5: // grade was between 60 and 69
                    ++DCount; // increment dCount
                    break; // exit switch
                default: // grade was less than 60
                    ++FCount; // increment fCount
                    break; // 


            }
        }

    }
}
