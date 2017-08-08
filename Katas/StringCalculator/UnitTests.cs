using NUnit.Framework;

namespace StringCalculator
{
    [TestFixture]
    public class UnitTests
    {
        private readonly StringCalc _stringCalc = new StringCalc();

        [Test]
        public void Add_EmptyStringReturnsZero()
        {
            Assert.AreEqual(0, _stringCalc.Add(string.Empty));
        }


        [TestCase(1, "1")]
        [TestCase(2, "2")]
        public void Add_SingleValuePassedReturnedAsInt(int expected, string passedString)
        {
            Assert.AreEqual(expected, _stringCalc.Add(passedString));
        }


        [TestCase(3, "1,2")]
        [TestCase(5, "3,2")]
        [TestCase(6, "1,2,3")]
        public void Add_SumValuesOfPassedCommaSeparatedString(int expected, string passedString)
        {
            Assert.AreEqual(expected, _stringCalc.Add(passedString));
        }


        [TestCase(6, "1\n2,3")]
        [TestCase(6, "1,2\n3")]
        [TestCase(6, "1\n2\n3")]
        public void Add_ShouldBeAbleToHandleNewLinesBetweenEntries(int expected, string passedString)
        {
            Assert.AreEqual(expected, _stringCalc.Add(passedString));
        }


        [Test]
        public void Add_CalculatorShouldHandleAlternativeDelimiters()
        {
            Assert.AreEqual(3, _stringCalc.Add("//;\n1;2"));
        }
    }
}