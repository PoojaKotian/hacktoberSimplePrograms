//compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
using System;
namespace Algos
{
    class SumwithTwist
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(1,2));
            Console.WriteLine(test(3,2));
            Console.WriteLine(test(2,2));
            Console.ReadLine();
        }

        public static int test(int x, int y)
        {
            return x == y ? (x + y)*3 : x + y;
        }
    }
}
