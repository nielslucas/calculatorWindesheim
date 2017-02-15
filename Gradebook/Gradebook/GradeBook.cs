using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class GradeBook
    {
        public string CourseName { get; set; }


        public GradeBook(string CourseName)
        {
            this.CourseName = CourseName;
        }
        public string DisplayMessage()
        {
            string message = "welcome to the grade book\n"+ CourseName;
            return message;
        }
    }
}
