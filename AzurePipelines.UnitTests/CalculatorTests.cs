using NUnit.Framework;

namespace AzurePipelines.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void TestAdd()
        {
            Calculator calculator = new Calculator();

            calculator.Add(2);
            calculator.Add(3);

            Assert.That(calculator.Total, Is.EqualTo(5));
        }

        [Test]
        public void TestSubtract()
        {
            Calculator calculator = new Calculator();

            calculator.Add(5);
            calculator.Subtract(2);

            Assert.That(calculator.Total, Is.EqualTo(3));
        }
    }
}
