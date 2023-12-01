using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class LinkedListImplement
    {
        LinkedList<int> ls;
        public LinkedListImplement() 
        {
            ls = new LinkedList<int>();
        }
        public void ImplementFunction()
        {
            ls.AddFirst(1);
            ls.AddFirst(2); 
            ls.AddFirst(3); 
            ls.AddFirst(4); 
            ls.AddFirst(5);
            ls.AddFirst(6);
            ls.RemoveFirst();
            //Console.WriteLine(ls.Count() + " is the count of nodes in the given linkedlist");
            ls.AddFirst(7);
            ls.AddFirst(9);
            ls.Find(4);
            ls.Remove(5);
            ls.RemoveLast();
            foreach(int i in ls)
            {
                Console.Write(i + " ");
            }
         }
        
    }
}
