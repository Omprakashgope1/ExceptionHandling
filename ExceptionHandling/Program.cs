using System.Security.Cryptography.X509Certificates;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {   try
            {
                Console.WriteLine("Mention age : ");
                string age = (Console.ReadLine());
                if(age == "" || age == null)
                {
                    throw new CustomException();
                }
                int NewAge = Convert.ToInt32(age);
                string ans = Age.FindPerson(NewAge);
                Console.WriteLine("Person is : " + ans);
            }
            catch (CustomException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch(FormatException ex2) 
            {
                Console.WriteLine(ex2.Message);
            }
        }
    }
}
