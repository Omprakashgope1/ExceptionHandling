using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures 
{ 
    internal class StackImplement
    {
        Stack<int> stack;
        public StackImplement()
        {
            stack = new Stack<int>();
        }
        public void implementStack()
        {
            stack.Push(0);
            stack.Push(1);
            stack.Push(100);
            stack.Push(200);
            stack.Pop();
            stack.Push(400);
            stack.Pop();
        }
        public void Display()
        {
            foreach(int key in stack)
            Console.Write(key + " ");
        }
    }
}
