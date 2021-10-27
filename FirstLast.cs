//exchange the first and last characters in a given string and return the new string
using System;
namespace exercises
{
  class FirstLast
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("abcd"));
            console.WriteLine("Enter a string: ");
            String str= Console.ReadLine(str);
            test(str);hacktoberfest
            Console.ReadLine();
        }


        public static string test(string str)
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
    }
}
