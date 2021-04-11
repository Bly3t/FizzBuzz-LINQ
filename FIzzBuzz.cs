using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        private static string FizzBuzz(int x)
        {
            if (x % 15 == 0)
            {
                return "FizzBuzz";
            }
            if (x % 5 == 0)
            {
                return "Buzz";
            }
            if (x % 3 == 0)
            {
                return "Fizz";
            }
            return x.ToString();
        }
        static void Main(string[] args)
        {
            Enumerable.Range(1, 100).Select(x => FizzBuzz(x)).ToList().ForEach(x =>
            {
                Console.WriteLine(x);
            });

        }
    }
}
