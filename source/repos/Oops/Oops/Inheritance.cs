using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Inheritance
    {
        public void ImplementInterface()
        {
            ChildClass ch = new ChildClass();
            ch.Looks();
            ch.strength();
        }
    }
    interface GrandFather
    {
        void Genes();
        void strength();
    }
    interface GranMother
    {
        void Looks();
        void Genes();
        void Brain();
    }
    class ParentClass : GrandFather, GranMother
    {
        public void Genes()
        {
            Console.WriteLine("Strong");
        }
        public void strength() 
        {
            Console.WriteLine("Heavy");
        }
        public void Brain() 
        {
            Console.WriteLine("Beautiful");
        }
        public void Looks()
        {
            Console.WriteLine("Charming");
        }
    }
    class ChildClass : ParentClass
    {
        public void Looks()
        {
            Console.WriteLine("OK");
        }
    }
}
