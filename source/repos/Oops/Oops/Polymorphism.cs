using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Polymorphism
    {
        Child ch;
        Parent parent;
        public Polymorphism()
        {
            ch = new Child();
            parent = new Parent();
        }
        public void CallPolymorphism()
        {
            Console.WriteLine("Which class you want to call(1:Parent & 2 : Child) : ");
            int val = Convert.ToInt32(Console.ReadLine());
            switch (val)
            {
                case 1:
                    parent.Work();
                    parent.Profession();
                    parent.Emotion();
                    parent.EatingHabbit();
                    parent.Work("Work according as work is given to you");
                    break;
                case 2:
                    ch.Work();
                    ch.Profession();
                    ch.Emotion();
                    ch.EatingHabbit();
                    ch.Work("Work and learn simultaneouly");
                    break;
                default:
                    Console.WriteLine("Wrong input provided");
                    break;
            }
        }
    }
    class Parent
    {
        public virtual void EatingHabbit()
        {
            Console.WriteLine("Eating a lot");
        }
        public virtual void Emotion()
        {
            Console.WriteLine("Getting angry fast");
        }
        public virtual void Profession()
        {
            Console.WriteLine("Doctor");
        }
        public void Work()
        {
            Console.WriteLine("doing work as per their need");
        }
        public void Work(string workIntstruction)
        {
            Console.WriteLine("doing work as per the workInstruction : " + workIntstruction);
        }
    }
    class Child : Parent
    {
        public override void EatingHabbit()
        {
            Console.WriteLine("Eating less");
        }
        public override void Emotion()
        {
            Console.WriteLine("Happy most of the times");
        }
        public override void Profession()
        {
            Console.WriteLine("Engineer");
        }

    }
}

