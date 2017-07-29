using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class UnitTests
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        [TestCase(7, "7")]
        [TestCase(8, "8")]
        public void ShouldReturnStringOfPassedIntValueWhenNotDivisbleByThreeOrFive(int input, string output)
        {
            Assert.AreEqual(output, FizzBuzz.ProduceStringFromInt(input));
        }


        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        [TestCase(18)]
        public void ShouldReturnStringFizzWhenIntValueOnlyDivisibleByThree(int input)
        {
            Assert.AreEqual("Fizz", FizzBuzz.ProduceStringFromInt(input));
        }


        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void ShouldReturnStringBuzzWhenIntValueOnlyDivisibleByFive(int input)
        {
            Assert.AreEqual("Buzz", FizzBuzz.ProduceStringFromInt(input));
        }


        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void ShouldReturnStringFizzBuzzWhenIntValueDivisibleByThreeAndFive(int input)
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.ProduceStringFromInt(input));
        }
    }
}