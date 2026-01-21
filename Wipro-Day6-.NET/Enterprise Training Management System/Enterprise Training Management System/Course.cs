using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise_Training_Management_System
{
    class Course                       // Defines Course class
    {
        public string CourseCode;      // Stores unique course code
        public string CourseName;      // Stores course name

        public Course(string code, string name)   // Constructor to create course
        {
            CourseCode = code;         // Assign code to CourseCode variable
            CourseName = name;         // Assign name to CourseName variable
        }
    }
}