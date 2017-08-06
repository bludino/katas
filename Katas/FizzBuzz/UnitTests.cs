using NUnit.Framework;
using System;

namespace FizzBuzz0608
{
    [TestFixture]
    public class UnitTests
    {
        private readonly FizzBuzz _fizzbuzz = new FizzBuzz();


        [TestCase(1, "1")]
        [TestCase(2, "2")]
        public void ConvertToString_ReturnsStringValueOfPassedInt(int passedInt, string expected)
        {
            Assert.AreEqual(expected, _fizzbuzz.ConvertToString(passedInt));
        }


        [TestCase(3)]
        [TestCase(6)]
        [TestCase(99)]
        public void ConvertToString_ReturnsFizzWhenIntDivisibleByThree(int passedInt)
        {
            Assert.AreEqual("Fizz", _fizzbuzz.ConvertToString(passedInt));
        }


        [TestCase(5)]
        [TestCase(10)]
        [TestCase(100)]
        public void ConvertToString_ReturnsBuzzWhenIntDivisibleByFive(int passedInt)
        {
            Assert.AreEqual("Buzz", _fizzbuzz.ConvertToString(passedInt));
        }


        [TestCase(15)]
        [TestCase(30)]
        public void ConvertToString_ReturnsFizzBuzzWhenIntDivisibleByThreeAndFive(int passedInt)
        {
            Assert.AreEqual("FizzBuzz", _fizzbuzz.ConvertToString(passedInt));
        }


        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-3)]
        public void ConvertToString_ShouldThrowExceptionIfPassedIntLessThanOne(int passedInt)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _fizzbuzz.ConvertToString(passedInt));
        }


        [Test]
        public void ConvertToString_ShouldThrowExceptionIfPassedIntGreaterThanOneHundred()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _fizzbuzz.ConvertToString(101));
        }


        [TestCase(0, "1")]
        [TestCase(2, "Fizz")]
        [TestCase(4, "Buzz")]
        [TestCase(14, "FizzBuzz")]
        [TestCase(99, "Buzz")]
        public void Run_CorrectItemIsAddedToListAtExpectedLocation(int index, string expected)
        {
            var fizzBuzzList = _fizzbuzz.Run();
            Assert.AreEqual(expected, fizzBuzzList[index]);
        }
    }
}