using System;
using System.Collections.Generic;

namespace FizzBuzz0608
{
    public class FizzBuzz
    {
        public List<string> Run()
        {
            var fizzBuzzList = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                fizzBuzzList.Add(ConvertToString(i));
            }

            return fizzBuzzList;
        }


        public string ConvertToString(int i)
        {
            if (i < 1 || i > 100)
                throw new ArgumentOutOfRangeException();

            if (i.IsDivisibleBy(15))
                return "FizzBuzz";

            else if (i.IsDivisibleBy(3))
                return "Fizz";

            else if (i.IsDivisibleBy(5))
                return "Buzz";

            return i.ToString();
        }
    }


    public static class Extensions
    {
        public static bool IsDivisibleBy(this int i, int divisor)
        {
            return i % divisor == 0;
        }
    }
}