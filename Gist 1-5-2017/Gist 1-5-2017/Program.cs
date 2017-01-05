using System;
using System.Collections.Generic;

//Gist 1: In C# create a new list of integers then populate the list with all
//even numbers from 0 to 100. Then print all of these numbers to the console.
//Once you have that loop through the list again and remove all numbers that are
//a multiple of 10. Then print all the remaining numbers to the console.

namespace Gist_1_5_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                    nums.Add(i);
            }

            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 0)
                    nums.Remove(i);
            }

            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}