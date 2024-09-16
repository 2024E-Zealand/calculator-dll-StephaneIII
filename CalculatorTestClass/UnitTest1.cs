using CalculatorClassLibrary;

namespace CalculatorTestClass
{
    [TestClass]
    public class UnitTest1
    {
        Operations operations = new Operations();
        [DataTestMethod]
        [DataRow(1,2,3)]
        public void AddTestFunctional(double a, double b, double expectedResult)
        {
            Assert.AreEqual(operations.Add(a, b), expectedResult);
        }

        [DataTestMethod]
        [DataRow(1, 2, -1)]
        [DataRow(5, 2, 3)]
        public void SubtractTestFunctional(double a, double b, double expectedResult)
        {
            Assert.AreEqual(operations.Subtract(a, b), expectedResult);
        }

        [DataTestMethod]
        [DataRow(1, 2, 2)]
        [DataRow(-6, 3, -18)]
        public void MultiplyTestFunctional(double a, double b, double expectedResult)
        {
            Assert.AreEqual(operations.Multiply(a, b), expectedResult);
        }

        [DataTestMethod]
        [DataRow(4, 2, 2)]
        [DataRow(-6, 3, -2)]
        public void divideTestFunctional(double a, double b, double expectedResult)
        {
            Assert.AreEqual(operations.divide(a, b), expectedResult);
        }
    }
}