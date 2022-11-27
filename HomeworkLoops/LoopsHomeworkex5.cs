using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLoops
{
    internal class LoopsHomeworkex5
    {
        public void Go()
        {
            int[]array1 = new int[8];
            int[]array2 = new int[8];
            int[]array3 = new int[8];
            Console.WriteLine("Enter 8 numbers: ");
           
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Enter element {0} ", i);
                array1[i] = int.Parse(Console.ReadLine());        
            }
            
            int j = 0;
            int k = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1 [i] % 2 == 0)
                {
                    array2[j] = array1[i];
                    j++;
                }
                else
                {
                    array3[k] = array1[i];
                    k++;
                }   
                   

                            
            }
            Console.WriteLine("even numbers: ");
            for (int i = 0; i < j; i++)
            {
                Console.Write(" {0} " , array2[i]);
            }
            Console.WriteLine(); 
            Console.WriteLine("odd numbers: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(" {0} " , array3[i]);
            }
        }

			
    }
}
