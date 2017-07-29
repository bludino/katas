using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(ProduceStringFromInt(i));
            }
        }


        public static string ProduceStringFromInt(int i)
        {
            if (i % 15 == 0)
                return "FizzBuzz";

            if (i % 3 == 0)
                return "Fizz";

            if (i % 5 == 0)
                return "Buzz";

            return i.ToString();
        }
    }
}