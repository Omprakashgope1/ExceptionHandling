using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Node<T>
    {
        public Node<T> next;
        public Node<T> prev;
        public T value;
        public Node(T value) 
        {
            this.value = value;
            this.next = null;
            this.prev = null;
        }
    }
    internal class LinkedListGen<T>
    {
        Node<T> head;
        Node<T> tail;
        public LinkedListGen()
        {
            head = null;
            tail = null;
        }
        public void AddLast(T value) 
        {
            Node<T> node = new Node<T>(value);
            if(tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                node.prev = tail;
                tail = node;
            }
        }
        public void AddFirst(T value) 
        {
            Node<T> node = new Node<T>(value);
            if(head != null)
            {
                Node<T> prev = head.prev;
                node.next = head;
                node.prev = null;
                head = node; 
            }
            else if(head == null)
            {
                tail = node;
                head = node;
            }
        }
        public void RemoveLast()
        {
            if (tail == null) throw new Exception("LinkedList does not contain anything");
            else if(tail == head)
            {
                tail = null;
                head = null;
            }
            else
            {
                Node<T> prev = tail.prev;
                tail.prev = null;
                tail = prev;
                prev.next = null;
            }
        }
        public void RemoveFirst()
        {
            if (head == null) throw new Exception("There is no element in the given linkedlist");
            else if(head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                Node<T> next = head.next;
                head.next = null;
                head = next;
                next.prev = null;
            }
        }
        public void DisplayNodes()
        {
            Node<T> curr = head;
            while (curr != tail)
            {
                Console.Write(curr.value + " ");
                curr = curr.next;
            }
            if(tail != null)
            Console.WriteLine(tail.value);
            Console.WriteLine();
        }
    }
}
