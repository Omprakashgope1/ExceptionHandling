using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class QueueGen<T>
    {
        T[] arr;
        int lastVal;
        int firstVal;
        int count;
        public QueueGen() 
        {
            arr = new T[10];
            firstVal = 0;
            lastVal = 0;
            count = 0;
        }
        public void Enqueue(T item) 
        {
            arr[lastVal] = item;
            lastVal++;
            if(lastVal == arr.Length) 
            {
                Array.Resize(ref arr, ((arr.Length/2) + 1)*3);
            }
            count++;
        }
        public T Dequeue() 
        {
            if (firstVal > lastVal)
            {
                throw new Exception("Index out of bound");
            }
            firstVal += 1;
            count--;
            return arr[firstVal -1];
        }
        public T Peek()
        {
            if (firstVal > lastVal) throw new Exception("Index out of bound");
            return arr[firstVal];
        }
        public int Size()
        {
            return count;
        }
        public void Display()
        {
            for(int i = firstVal;i < lastVal;i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
