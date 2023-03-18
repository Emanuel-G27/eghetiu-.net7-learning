using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSolution
{
    public class CustomStack<T>
    {

        private List<T> elements;
        public CustomStack()
        {
            elements = new List<T>();
        }

        public void Push(T elem)
        {
            elements.Add(elem);
        }

        public T Top()
        {
            return elements[elements.Count - 1];
        }

        public T Pop()
        {
            var elem = elements[elements.Count - 1];

            elements.RemoveAt(elements.Count - 1);

            return elem;
        }
    }
}
