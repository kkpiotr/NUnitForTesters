using NUnit.Framework;
using NUnitForTesters.Services;

namespace NUnitForTesters.Test.Services
{
    public class CalculatorServiceTests
    {
        CalculatorService calculatorService;

        [SetUp]
        public void Init()
        {
            calculatorService = new CalculatorService();
        }


        [TestCase(1, 1, 2)]
        public void AddTest(int a, int b, int c)
        {
           Assert.AreEqual(calculatorService.Add(a, b), c);

        }

        [Test]
        public void SubTest()
        {
            Assert.AreEqual(calculatorService.Sub(1, 1), 0);

        }

        [Test]
        public void MulTest()
        {
            Assert.AreEqual(calculatorService.Mul(2, 2), 4);

        }

        [Test]
        public void DivTest()
        {
            Assert.AreEqual(calculatorService.Div(4, 2), 2);

        }



    }
}