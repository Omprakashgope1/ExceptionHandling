using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Node 
    {
        public int val;
        public Node next;
        public Node prev;
        public Node(int val) 
        {
            this.val = val;
            this.next = null;
            this.prev = null;
        }
    }
    internal class LinkedListDesending
    {
        Node head;
        Node tail;
        public LinkedListDesending() 
        {
            head = null;
            tail = null;
        }
        public void Add(int val) 
        {
            Node nn = new Node(val);
            if(head == null)
            {
                head = nn;
                tail = nn; 
            }
            else if(head.val < val)
            {
                nn.next = head;
                head.prev = nn;
                head = nn;
            }
            else
            {
                Node curr = head;
                while(curr != null)
                {
                    if(curr.val < val)
                    {
                        Node prev = curr.prev;
                        nn.prev = prev;
                        prev.next = nn;
                        nn.next = curr;
                        curr.prev = nn;
                        break;
                    }
                    curr = curr.next;
                }
                if(curr == null)
                {
                    tail.next = nn;
                    nn.prev = tail;
                    tail = nn;
                }
            }
        }
        public void Print()
        {
            Node curr = head;
            while(curr != null) 
            {
                Console.Write(curr.val + " ");
                curr = curr.next;
            }
            Console.WriteLine();
        }
    }
}
