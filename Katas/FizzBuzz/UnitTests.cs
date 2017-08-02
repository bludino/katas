using NUnit.Framework;
using System;

namespace FizzBuzz
{
    [TestFixture]
    public class UnitTests
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        public void ShouldReturnStringOfPassedInt(int input, string expected)
        {
            Assert.AreEqual(expected, Main.FizzBuzz(input));
        }

        [TestCase(3)]
        [TestCase(6)]
        public void ShouldReturnFizzOnIntsDivisibleByThree(int input)
        {
            Assert.AreEqual("Fizz", Main.FizzBuzz(input));
        }


        [TestCase(5)]
        [TestCase(10)]
        public void ShouldReturnBuzzOnIntsDivisibleByFive(int input)
        {
            Assert.AreEqual("Buzz", Main.FizzBuzz(input));
        }


        [TestCase(15)]
        [TestCase(30)]
        public void ShouldReturnFizzBuzzOnIntsDivisibleByThreeAndFive(int input)
        {
            Assert.AreEqual("FizzBuzz", Main.FizzBuzz(input));
        }


        [TestCase(0)]
        [TestCase(-1)]
        public void ShouldThrowExceptionWhenIntLessThanOnePassed(int input)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Main.FizzBuzz(input));
        }


        [Test]
        public void ShouldThrowExceptionWhenIntGreaterThanOneHundredPassed()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Main.FizzBuzz(101));
        }
    }
}