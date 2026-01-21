using Enterprise_Training_Management_System;
using System;                        // Basic system features

class Program
{
    static void Main()               // Program execution starts here
    {
        ETMS system = new ETMS();    // Create ETMS object

        system.AddCourse("C101", "C# Fundamentals");
        system.AddCourse("C102", "Advanced .NET");

        system.DisplayCourses();     // Show courses

        system.RequestEnrollment(1, "C101");
        system.RequestEnrollment(2, "C102");
        system.RequestEnrollment(1, "C101"); // Duplicate

        system.ProcessEnrollments(); // Process enrollment requests

        system.AddSession(DateTime.Now.AddDays(1), "C# Morning Session");
        system.AddSession(DateTime.Now.AddDays(2), "Advanced .NET Session");

        system.DisplaySessions();    // Show sessions

        system.UndoLastAction();     // Undo last admin action

        Console.ReadLine();          // Keep console open
    }
}
