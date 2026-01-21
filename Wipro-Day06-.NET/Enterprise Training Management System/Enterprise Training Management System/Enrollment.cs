using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise_Training_Management_System
{

    class Enrollment                   // Represents a learner enrollment
    {
        public int LearnerId;          // Stores learner unique ID
        public string CourseCode;      // Stores enrolled course code

        public Enrollment(int learnerId, string courseCode) // Constructor
        {
            LearnerId = learnerId;     // Assign learner ID
            CourseCode = courseCode;   // Assign course code
        }
    }

}
