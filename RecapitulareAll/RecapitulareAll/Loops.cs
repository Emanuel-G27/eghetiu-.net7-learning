using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareAll
{
    public class Loops
    {
        public void Go1()
        {
            //For loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"For loops are : {i}");
            }
        }

        public void Go2()
        {
            //foreach

            string[] names = new string[5] { "emi", "adi", "ion", "Ina", "Franci" };

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            //while

            var name2 = "Franci";
            var name1 = "Noah";

            while(name1 == "Noah")
            {
                Console.WriteLine("Good night");
                break;
            }

            //do while

            int num = 0;
            do
            {
                Console.WriteLine(num);
                num++;
            }while(num < 5);
        }
    }
}
