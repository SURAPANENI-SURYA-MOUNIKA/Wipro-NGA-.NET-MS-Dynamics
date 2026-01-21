using System;

namespace GradeCalculator  
{
    public class GradeCalculator1
    {
        public int CalculateTotalMarks(int mark1, int mark2, int mark3)
        {
            if (mark1 < 0 || mark2 < 0 || mark3 < 0)
                throw new ArgumentOutOfRangeException("Marks cannot be negative.");
            if (mark1 > 100 || mark2 > 100 || mark3 > 100)
                throw new ArgumentOutOfRangeException("Marks cannot exceed 100.");
            return mark1 + mark2 + mark3;
        }

        public double CalculateAverage(int mark1, int mark2, int mark3)
        {
            return CalculateTotalMarks(mark1, mark2, mark3) / 3.0;
        }

        public string GetGrade(int mark1, int mark2, int mark3)
        {
            double avg = CalculateAverage(mark1, mark2, mark3);
            if (avg >= 80) return "A";
            if (avg >= 60) return "B";
            if (avg >= 40) return "C";
            return "Fail";
        }
    }
}