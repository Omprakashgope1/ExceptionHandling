using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    
    internal class Age
    {
        public static string FindPerson(int age)
        {
            if (age < 0) throw new CustomException();
            if(age >= 1 && age <= 14)
            {
                return "Child";
            }
            else if(age >= 15 && age <= 24)
            {
                return "Youth";
            }
            else if(age >= 25 && age <= 64)
            {
                return "Adults";
            }
            return "Seniors";
        }

    }
}
