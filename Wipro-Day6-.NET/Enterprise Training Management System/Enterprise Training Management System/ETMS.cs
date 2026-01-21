using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise_Training_Management_System
{
  

    class ETMS                               // Enterprise Training Management System
    {
        private List<Course> courseList = new List<Course>();
        // Stores courses in order

        private Dictionary<string, Course> courseLookup =
            new Dictionary<string, Course>();
        // Fast lookup by course code

        private HashSet<int> enrolledLearners = new HashSet<int>();
        // Prevents duplicate learner enrollments

        private Queue<EnrollmentRequest> enrollmentQueue =
            new Queue<EnrollmentRequest>();
        // Processes requests in FIFO order

        private Stack<AdminAction> adminActions =
            new Stack<AdminAction>();
        // Supports undo functionality

        private SortedList<DateTime, string> sessions =
            new SortedList<DateTime, string>();
        // Stores sessions sorted by date

        private ConcurrentDictionary<int, Enrollment> concurrentEnrollments =
            new ConcurrentDictionary<int, Enrollment>();
        // Thread-safe enrollments

        public void AddCourse(string code, string name)   // Adds course
        {
            Course course = new Course(code, name);       // Create course object
            courseList.Add(course);                       // Add to list
            courseLookup[code] = course;                  // Add to dictionary
            adminActions.Push(new AdminAction("Added course " + code));
            // Track admin action
        }

        public void DisplayCourses()                      // Display courses
        {
            Console.WriteLine("Available Courses:");
            foreach (Course c in courseList)              // Loop through courses
            {
                Console.WriteLine(c.CourseCode + " - " + c.CourseName);
            }
        }

        public void RequestEnrollment(int learnerId, string courseCode)
        {
            EnrollmentRequest request =
                new EnrollmentRequest(learnerId, courseCode);
            // Create enrollment request

            enrollmentQueue.Enqueue(request);             // Add to queue
        }

        public void ProcessEnrollments()                  // Process requests
        {
            while (enrollmentQueue.Count > 0)             // While queue has data
            {
                EnrollmentRequest request =
                    enrollmentQueue.Dequeue();            // Remove first request

                if (enrolledLearners.Contains(request.LearnerId))
                {
                    Console.WriteLine("Duplicate enrollment blocked.");
                    continue;                             // Skip duplicate
                }

                Enrollment enrollment =
                    new Enrollment(request.LearnerId, request.CourseCode);
                // Create enrollment

                if (concurrentEnrollments.TryAdd(
                    request.LearnerId, enrollment))       // Thread-safe add
                {
                    enrolledLearners.Add(request.LearnerId);
                    Console.WriteLine("Enrollment successful for learner " +
                                      request.LearnerId);
                }
            }
        }

        public void AddSession(DateTime time, string name)
        {
            sessions.Add(time, name);                     // Add sorted session
        }

        public void DisplaySessions()
        {
            Console.WriteLine("Training Sessions:");
            foreach (var s in sessions)                   // Loop sorted sessions
            {
                Console.WriteLine(s.Key + " - " + s.Value);
            }
        }

        public void UndoLastAction()                       // Undo admin action
        {
            if (adminActions.Count > 0)                   // Check stack
            {
                AdminAction action = adminActions.Pop();  // Remove last action
                Console.WriteLine("Undo: " + action.ActionDescription);
            }
            else
            {
                Console.WriteLine("No actions to undo.");
            }
        }
    }

}
