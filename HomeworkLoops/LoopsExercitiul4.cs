using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLoops
{
    internal class LoopsExercitiul4
    {
        public void Go()
        {
            int[] arr = { 32, 3, 3, 47, 12, 4, 6, 12, 50, 4, 47, 47 };

            var dict = new Dictionary<int, int>();
            foreach (var value in arr)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }

            foreach (var pair in dict)
            {
                Console.WriteLine(" {0} = {1} time(s)", pair.Key, pair.Value);
            }
        }   
    }
}
