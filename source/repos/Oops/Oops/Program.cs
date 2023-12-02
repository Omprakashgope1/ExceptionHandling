namespace Oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operation number you want to operate with :");
           int val = Convert.ToInt32 (Console.ReadLine());  
           switch(val)
            {
                case 1:
                    Class1 cl1 = new Class1();
                    cl1.callPerson();
                    break;
                case 2:
                    Class2 class2 = new Class2();
                    class2.InterfaceFunc();
                    break;
                case 3:
                    Polymorphism polymorphism = new Polymorphism();
                    polymorphism.CallPolymorphism();
                    break;
                case 4:
                    Encapsultion en = new Encapsultion();
                    en.callEncapsulation();
                    break;
                case 5:
                    Abstraction ab = new Abstraction();
                    ab.callAbstraction();
                    break;
                case 6:
                    ChoosingVar cv = new ChoosingVar();
                    cv.ChooseVar(); ;
                    break;
                case 7:
                    Inheritance inh = new Inheritance();
                    inh.ImplementInterface();
                    break;
                default:
                    Console.WriteLine("Wrong input given");
                    break;
            }
        }
    }
}
