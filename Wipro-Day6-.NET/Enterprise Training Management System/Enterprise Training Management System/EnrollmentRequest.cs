using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise_Training_Management_System
{

    class EnrollmentRequest               // Represents enrollment request
    {
        public int LearnerId;              // Learner requesting enrollment
        public string CourseCode;          // Requested course

        public EnrollmentRequest(int learnerId, string courseCode)
        {
            LearnerId = learnerId;         // Assign learner ID
            CourseCode = courseCode;       // Assign course code
        }
    }

}
