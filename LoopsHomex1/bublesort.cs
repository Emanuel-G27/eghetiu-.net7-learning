using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LoopsHomex1
{
    internal class bublesort
    {
        public void Buble()
        {
            int[] arr = { 5, 4, 3, 2, 1  };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length- i -1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = tmp;
                    } 
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
                
        }
    }
}
