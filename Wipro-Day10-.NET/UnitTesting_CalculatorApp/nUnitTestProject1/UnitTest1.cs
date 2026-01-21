using UnitTesting_CalculatorApp;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace nUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Addition_of_Two_Number()
        {
            Calculator calculator = new Calculator();
            // syntax 
            // Assert.That(actual, Is.EqualTo(expected));
            //these are test cases checking diff scenario of add
            Assert.That(calculator.Add(10, 20), Is.EqualTo(30));
            Assert.That(calculator.Add(-5, -3), Is.EqualTo(-8));
            Assert.That(calculator.Add(12, -34), Is.EqualTo(-22));
            Assert.That(calculator.Add(0, 0), Is.EqualTo(0));
            Assert.That(calculator.Add(100000000, 20000), Is.EqualTo(100020000));

        }
        public void Add_TwoNumbers_returnCorrectedSum(int a, int b, int exp)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(a, b);
            Assert.That(exp, Is.EqualTo(result));


        }

    }
}




































/*using UnitTesting_CalculatorApp;
using NUnit.Framework;

namespace nUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Addition_of_Two_Number()
        {
            Calculator calculator = new Calculator();

            Assert.That(calculator.Add(10, 20), Is.EqualTo(30));
            Assert.That(calculator.Add(-5, -3), Is.EqualTo(-8));
            Assert.That(calculator.Add(12, -34), Is.EqualTo(-22));
            Assert.That(calculator.Add(0, 0), Is.EqualTo(0));
            Assert.That(calculator.Add(100000000, 2000000), Is.EqualTo(102000000));
        }

        // Fixed: Added [TestCase] attributes + corrected assert order
        [TestCase(10, 20, 30)]
        [TestCase(-5, -3, -8)]
        [TestCase(12, -34, -22)]
        [TestCase(0, 0, 0)]
        [TestCase(100000000, 2000000, 102000000)]
        public void Add_TwoNumbers_returnCorrectedSum(int a, int b, int expected)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(a, b);

            // Fixed: actual value FIRST, expected SECOND
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

*/