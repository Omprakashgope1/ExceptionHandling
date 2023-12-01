using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class StackGen<T>
    {
        T[] arr;
        int lastVal;
        int count;
        public StackGen()
        {
            arr = new T[10];
            lastVal = 0;
            count = 0;
        }
        public void Push(T item) 
        {
            if (lastVal < 0) lastVal = 0;
            arr[lastVal] = item;
            lastVal++;
            if(lastVal >= arr.Length) 
            {
                Array.Resize(ref arr, ((arr.Length / 2) + 1) * 3);
            }
        }
        public T Pop() 
        {
            if (lastVal < 0) throw new Exception("Index out of bound");
            lastVal--;
            return arr[lastVal + 1];
        }
        public T Peek()
        {
            if (lastVal < 0) throw new Exception("Index out of bound");
            return arr[lastVal];
        }
        public void Display()
        {
            for(int i = 0;i < lastVal;i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();    
        }
    }
}
