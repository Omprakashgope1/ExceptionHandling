using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class ChoosingVar
    {
        public void ChooseVar()
        {
            Variables callVaraible = new Variables("Ram");
            Console.WriteLine("Name of the Person : " + callVaraible.name + "\n count of the person : " + Variables.count);
            Variables callVariable2 = new Variables("Shyam");
            Console.WriteLine("Name of the Person : " + callVariable2.name + "\n count of the person : " + Variables.count);
        }
    }
    class Variables
    { 
        public String name;//instance variable
        public static int count = 0;//class variable
        public const string school = "APS";//final variable
        public Variables(string name) 
        {
            this.name = name;
            count += 1;//this belongs to the class
        }
        public void otherVariables(int requiredAge)
        {
            int age = requiredAge;//local variables
        }
    }

}
