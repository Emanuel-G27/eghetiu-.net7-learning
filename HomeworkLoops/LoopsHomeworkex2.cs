using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLoops
{
    internal class LoopsHomeworkex2
    {
        public void Go()
        {
            int[] array = { 1, 2, 2, 3, 4, 6, 7, 7 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }

        }
    }
}
