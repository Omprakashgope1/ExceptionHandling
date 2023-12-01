using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class QueueImplementation
    {
        Queue<int> q;
        public QueueImplementation() 
        {
            q = new Queue<int>();
        }
        public void implementQueue()
        {
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(1);
            q.Enqueue(4);
            q.Dequeue();
            q.Dequeue();
            q.Peek();
            foreach(var item in q)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
