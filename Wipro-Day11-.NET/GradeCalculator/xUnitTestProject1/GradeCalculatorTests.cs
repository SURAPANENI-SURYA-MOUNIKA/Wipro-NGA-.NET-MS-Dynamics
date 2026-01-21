using Xunit;
using GradeCalculator;           

namespace xUnitTestProject1
{
    public class GradeCalculatorTests
    {
        
        private readonly GradeCalculator1 _calculator = new GradeCalculator1();


        // Test 1: Calculate total marks for 3 valid subjects
        
        [Fact]
        public void CalculateTotalMarks_WithThreeValidSubjects_ReturnsCorrectSum()
        {
            // Arrange – prepare valid input values
            int m1 = 78;
            int m2 = 85;
            int m3 = 92;

            // Act – call the method under test
            int total = _calculator.CalculateTotalMarks(m1, m2, m3);

            // Assert – check the result is correct
            Assert.Equal(255, total);
        }


        // Test 2: Total marks should be 0 when all marks are 0
        [Fact]
        public void CalculateTotalMarks_WhenAllMarksAreZero_ReturnsZero()
        {
            // Arrange
            int m1 = 0, m2 = 0, m3 = 0;

            // Act
            int total = _calculator.CalculateTotalMarks(m1, m2, m3);

            // Assert
            Assert.Equal(0, total);
        }


        // Test 3: Average calculation should be correct
        [Fact]
        public void CalculateAverage_WithValidMarks_ReturnsCorrectAverage()
        {
            // Arrange – marks that give nice round average
            int m1 = 60;
            int m2 = 75;
            int m3 = 90;

            // Act
            double avg = _calculator.CalculateAverage(m1, m2, m3);

            // Assert – allow small floating-point difference
            Assert.Equal(75.0, avg, precision: 3);
        }


        // Test 4: Grade A when average ≥ 80
        [Fact]
        public void GetGrade_AverageIs80OrAbove_ReturnsA()
        {
            // Arrange – average 85
            int m1 = 80, m2 = 85, m3 = 90;

            // Act
            string grade = _calculator.GetGrade(m1, m2, m3);

            // Assert
            Assert.Equal("A", grade);
        }


        // Test 5: Grade B when average is between 60–79
        [Fact]
        public void GetGrade_AverageIsBetween60And79_ReturnsB()
        {
            // Arrange – average ≈ 69
            int m1 = 65, m2 = 70, m3 = 72;

            // Act
            string grade = _calculator.GetGrade(m1, m2, m3);

            // Assert
            Assert.Equal("B", grade);
        }


        // Test 6: Grade C when average is between 40–59
        [Fact]
        public void GetGrade_AverageIsBetween40And59_ReturnsC()
        {
            // Arrange – average = 50
            int m1 = 45, m2 = 50, m3 = 55;

            // Act
            string grade = _calculator.GetGrade(m1, m2, m3);

            // Assert
            Assert.Equal("C", grade);
        }


        // Test 7: Fail when average < 40
        [Fact]
        public void GetGrade_AverageIsBelow40_ReturnsFail()
        {
            // Arrange – average ≈ 34.33
            int m1 = 30, m2 = 35, m3 = 38;

            // Act
            string grade = _calculator.GetGrade(m1, m2, m3);

            // Assert
            Assert.Equal("Fail", grade);
        }


        // Test 8: Negative mark should throw exception
        [Fact]
        public void CalculateTotalMarks_NegativeMark_ThrowsException()
        {
            // Act & Assert – expect specific exception type
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() =>
                _calculator.CalculateTotalMarks(-5, 70, 80));

            // Optional: check that the message contains expected text
            Assert.Contains("negative", ex.Message, StringComparison.OrdinalIgnoreCase);
        }


        // Test 9: Mark > 100 should throw exception
       
        [Fact]
        public void CalculateTotalMarks_MarkAbove100_ThrowsException()
        {
            // Act & Assert
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() =>
                _calculator.CalculateTotalMarks(101, 75, 82));

            // Optional: check message
            Assert.Contains("exceed 100", ex.Message, StringComparison.OrdinalIgnoreCase);
        }


        // Test 10: GetGrade should throw when input is invalid
        //         (because it calls CalculateTotalMarks internally)
       
        [Fact]
        public void GetGrade_WithInvalidInput_ThrowsException()
        {
            // Act & Assert – negative mark should propagate the exception
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                _calculator.GetGrade(-10, 60, 70));
        }
    }
}