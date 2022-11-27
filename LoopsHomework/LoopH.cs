using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsHomework
{
    internal class LoopH
    {
        public void Go()
        {
            List<string> l1 = new List<string>() { "a", "b", "c", "d", "c", "d", "e", "a", "f", "f" };
            var remove = l1.Distinct().ToList();
            Console.WriteLine(string.Join(", ", remove));
        }
    }
}
