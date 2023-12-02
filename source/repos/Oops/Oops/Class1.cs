using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Class1
    {
        int height;
        double weight;
        string name;
        public void callPerson()
        {
            Console.WriteLine("Please enter the name of the person");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the height of the person");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the weight of the person");
            weight = Convert.ToDouble(Console.ReadLine());   
            Person p1 = new Person(height,weight,name);
            Console.WriteLine(p1);
        }
    }
    class Person
    {
        string name;
        int height;
        double weight;
        public Person(int height,double weight,string name) 
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
        }
        public override string ToString()
        {
            return "Person name is : " + this.name +
                   " ,\nheight of the person : " + this.height +
                   " ,\nweight of the person :" + this.weight; 
        }
    }
}
