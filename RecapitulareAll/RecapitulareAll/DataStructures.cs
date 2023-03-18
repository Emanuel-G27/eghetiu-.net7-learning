using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareAll
{
    public class DataStructures
    {
        public void Go()
        {
            // Data Structures

            // ARRAY

            string[] employees = new string[] { "Edi", "Marcu", "Alin" };
            Console.WriteLine(employees[2]);

            int[] numbers = { 1, 2, 4, 5, 6, 6, 7, 8 };
            Console.WriteLine($"{numbers[2]}");
            Console.WriteLine();
            foreach (var item in numbers)

                Console.WriteLine(item);

            Console.WriteLine();
            numbers[6] = 1990;
            Console.WriteLine(numbers[6]);

            Console.WriteLine($"{numbers[2]}");

            string c = employees[1];
            Console.WriteLine(c);

            // 2 dimensional array

            int[,] sales =
            {
    {1, 2, 7, 9},
    {2, 3, 10, 67},
    {3, 4, 12, 13},
    {4, 5, 45, 56 }
};

            for (int i = 0; i <= sales.GetLength(0); i++)
            {
                for (int b = 0; b <= sales.GetLength(1); b++)
                {
                    Console.WriteLine("Sales: " + sales[i, b]);
                }

            }




            // LIST

            List<int> numbers2 = new List<int>() { 123, 345345634, 3466, 765 };
            numbers2.Add(12);
            numbers2[1] = 1;

            Console.WriteLine(numbers2[1]);

            Console.WriteLine(string.Join(",", numbers2));

            // QUEUE FIFO- FIRST IN FIRST OUT

            Queue<string> line = new Queue<string>();

            // adding values-enqueue
            line.Enqueue("Ada");
            line.Enqueue("Marius");
            line.Enqueue("Mihai");

            Console.WriteLine(string.Join(",", line));

            // removing values
            line.Dequeue();

            Console.WriteLine(string.Join(",", line));

            // accessing element

            string best = line.ElementAt(0);

            Console.WriteLine(best);

            string best2 = line.Peek();
            Console.WriteLine(best2);

            // STACK LIFO- LAST IN FIRST OUT

            Stack<int> math = new Stack<int>();
            math.Push(1);
            math.Push(2);
            math.Push(3);
            math.Push(4);

            Console.WriteLine(string.Join(",", math));

            // accessing element

            var x = math.ElementAt(1);
            Console.WriteLine(x);

            var y = math.Peek();

            Console.WriteLine(y);

            // DICTIONARY

            Dictionary<int, string> map = new Dictionary<int, string> { { 4, "Edi" } };
            map.Add(12, "Ion");
            map.Add(13, "Vasile");

            Console.WriteLine(string.Join(",", map));

            map.Add(90, "Adi");
            map.Remove(12);

            Console.WriteLine(string.Join(",", map));

            // accessing element in a dictionary

            var w = map[13];
            Console.WriteLine(w);
        }
    }
}
