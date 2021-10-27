////program to check whether the value of each element is equal or greater than the value of previous element of a given array of integers.
using System;
namespace exercises
{
   class valuecheck
    {       
        static void Main(string[] args)
        {               
         Console.WriteLine(test(new[] { 5, 5, 1, 5, 5 })); 
         Console.WriteLine(test(new[] { 1, 2, 3, 4 })); 
         Console.WriteLine(test(new[] { 3, 3, 5, 5, 5, 5})); 
         Console.WriteLine(test(new[] { 1, 5, 5, 7, 8, 10})); 
          }               
        static bool test(int[] numbers)
         {
          for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] < numbers[i]) return false;
            }

            return true;
         }
    
    } 
 }
