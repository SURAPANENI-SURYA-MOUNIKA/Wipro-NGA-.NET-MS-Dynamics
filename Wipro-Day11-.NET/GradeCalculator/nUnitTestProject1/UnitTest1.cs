using Xunit;

namespace nUnitTestProject1.Tests     // ← change this if your namespace is different
{
    public class GradeCalculatorTests
    {
        private readonly GradeCalculator _calculator = new GradeCalculator();

        [Fact]
        public void CalculateTotalMarks_WithThreeValidSubjects_ReturnsCorrectSum()
        {
            // Arrange
            int m1 = 78, m2 = 85, m3 = 92;

            // Act
            int total = _calculator.CalculateTotalMarks(m1, m2, m3);

            // Assert
            Assert.Equal(255, total);   // cleaner than 78+85+92
        }

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

        // Add your other 8 tests here in the same pattern...
    }
}