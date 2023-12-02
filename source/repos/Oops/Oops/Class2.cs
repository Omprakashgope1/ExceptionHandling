using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Class2
    {
        public void InterfaceFunc()
        {
            Console.WriteLine("Make a choice which one you want to try :");
            int val = Convert.ToInt32(Console.ReadLine());
            switch(val)
            {
                case 1:
                    Bmw bmw = new Bmw(4,"black",280,"BMWX1");
                    Console.WriteLine(bmw.ToString());
                    bmw.sound();
                    break;
                case 2:
                    Honda hn = new Honda(2, "white", 120, "Avaitor");
                    Console.WriteLine(hn.ToString());
                    hn.sound();
                    break;
                default:
                    Console.WriteLine("Wrong option choosen");
                    break;
            }
        }
    }
    class Vechile
    {
        public string model,color;
        public int noOfWheels,maxSpeed;
        public virtual void sound()
        {
            Console.WriteLine("Vroon Vroon");
        }
    }
    class Bmw : Vechile
    {
        public Bmw(int noOfWheels,string color,int maxSpeed,string model)
        {
            this.model = model;
            this.noOfWheels = noOfWheels;
            this.color = color;
            this.maxSpeed = maxSpeed;
        }
        public override void sound()
        {
            Console.WriteLine("Vrooooom");
        }
        public override string ToString()
        {
            return "Features : brand = " + model + " ,Number of wheels = " + noOfWheels + " ,Color = " + color + "MaxSpeed = " + maxSpeed;
        }
    }
    class Honda : Vechile
    {
        public Honda(int noOfWheels,string color,int maxSpeed,string model)
        {
            this.model = model;
            this.noOfWheels= noOfWheels;
            this.color = color;         
            this.maxSpeed = maxSpeed;   
        }
        public override void sound()
        {
            Console.WriteLine("vrim vrim");
        }
        public override string ToString()
        {
            return "Features : brand = " + model + " ,Number of wheels = " + noOfWheels + " ,Color = " + color + "MaxSpeed = " + maxSpeed;
        }
    }
}
