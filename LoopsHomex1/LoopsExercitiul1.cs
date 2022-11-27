using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsHomex1
{
    internal class LoopsExercitiul1
    {
        public void Go()
        {
            //  1.Given an array of integer numbers, print the total
            //  of all the values that are even numbers.
            // [1, 2, 3, 4, 5]->total = 6

            int[] arr = new[] { 4, 9, 2, 5, 1, 4, 8, 3, 3, 4, 6, 10, 26 };
            int even = 0;          
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even += arr[i];
                }                           
            }
            Console.WriteLine("The total of even numbers is: " + even);
           









        }
    }
}
