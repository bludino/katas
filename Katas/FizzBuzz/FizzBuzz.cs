using System;

namespace FizzBuzz
{
    public static class Main
    {
        public static string FizzBuzz(int i)
        {
            if (i < 1 || i > 100)
                throw new ArgumentOutOfRangeException();

            if (i.IsDivisibleBy(15))
                return "FizzBuzz";

            if (i.IsDivisibleBy(3))
                return "Fizz";

            if (i.IsDivisibleBy(5))
                return "Buzz";

            return i.ToString();
        }


        private static bool IsDivisibleBy(this int i, int divisor)
        {
            return i % divisor == 0;
        }
    }
}