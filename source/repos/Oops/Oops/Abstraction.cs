using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Abstraction
    {
        bool wantToContinue;
        Square sq;
        Rect rect;
        public Abstraction() 
        {
            wantToContinue = true;
        }
        public void callAbstraction()
        {
            while(wantToContinue)
            {
                Console.WriteLine("Choose the sequence you want to work with(1: rectangle , 2 : square");
                int val = Convert.ToInt32(Console.ReadLine());
                if (val == 1)
                {
                    Console.WriteLine("Please enter the length");
                    int len = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the width");
                    int width = Convert.ToInt32(Console.ReadLine());
                    rect = new Rect(len, width);
                    rect.findArea();
                    rect.findPerimeter();
                }
                else if(val == 2)
                {
                    Console.WriteLine("Please enter the length");
                    int len = Convert.ToInt32(Console.ReadLine());
                    sq = new Square(len);
                    sq.findArea();
                    sq.findPerimeter();    
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
    }
    public abstract class Figure()
    {
        public int len;
        public int width;
        public int radius;
        public int height;
        public const double pi = Math.PI;
        public virtual void findArea() { }
        public virtual void findPerimeter() { }

    }
    class Rect : Figure
    {
        public Rect(int len,int width)
        {
            this.len = len;
            this.width = width;
        }
        public override void findArea()
        {
            Console.WriteLine("The are of this rectangle is : " +(len * width));
        }
        public override void findPerimeter() 
        {
            Console.WriteLine("The Perimeter of this rectange is : " + 2*(len + width));
        }    
    }
    class Square : Figure
    {
        public Square(int len)
        {
            base.len = len;
        }
        public override void findArea()
        {
            Console.WriteLine("The are of this rectangle is : " + (len * len));
        }
        public override void findPerimeter()
        {
            Console.WriteLine("The Perimeter of this rectange is : " + (4 * len));
        }
    }
}