using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueuesLab
{
    public class MyQueue<T> : IQueue<T>
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;

        public T Dequeue()
        {
            T item = items[0];
            items.RemoveAt(0);
            return item;
        }

        public void Enqueue(T item)
        {
            items.Add(item);
        }

        public T Peek()
        {
            return items[0];
        }
    }
}
