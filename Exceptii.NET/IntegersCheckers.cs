using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptii.NET
{
    public class IntegersCheckers
    {
        public void CheckTheIntegers()
        {
            List<int> list1 = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the numbers: ");
                int input = int.Parse(Console.ReadLine());
                list1.Add(input);
            }
            foreach(int input in list1)
            {
                if(input < 0)
                {
                    throw new NegativeNumberExceptions("Invalid");
                }
            }
        }
    }
    public class NegativeNumberExceptions : Exception
    {
        public NegativeNumberExceptions(string? message) : base(message)
        {}
    }
}
