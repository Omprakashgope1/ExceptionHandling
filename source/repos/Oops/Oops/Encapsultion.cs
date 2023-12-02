using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Encapsultion
    {
        Bank bank;
        bool wantToContinue;
        public Encapsultion()
        {
            bank = new Bank();
            wantToContinue = true;
        }
        public void callEncapsulation()
        {
            while (wantToContinue)
            {
                Console.WriteLine("Select the sequence of operation you want to do (1:set account Number , 2 : get account number , 3 : want to deposit some money ,4 : want to know your balance");
                int val = Convert.ToInt32(Console.ReadLine());
                switch (val)
                {
                    case 1:
                        Console.WriteLine("Please enter the 12 digit account number \nIt should only contain digits");
                        string accountNumber = Console.ReadLine();
                        bank.SetAccountNumber(accountNumber);
                        break;
                    case 2:
                        Console.WriteLine("Your account number is : " + bank.GetAccountNumber());
                        break;
                    case 3:
                        Console.WriteLine("Please enter the amount you want to deposit");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        bank.SetBalance(amount);
                        break;
                    case 4:
                        Console.WriteLine("Your account balance is : " + bank.GetBalance());
                        break;
                    default:
                        Console.WriteLine("Please enter the correct sequence number");
                        break;

                }
                Console.WriteLine("Want to continue (Y/N)");
                string continueVal = Console.ReadLine().ToUpper();
                if (continueVal != "Y")
                {
                    wantToContinue = false;
                }
            }
        }
    }
    class Bank
    {
        double balance;
        String accountNumber;
        public void SetBalance(double amount)
        {
            if(this.accountNumber == null)
            {
                Console.WriteLine("Please create a account number before adding balance");
                return;
            }
            if (amount > 0) balance += amount;
        }
        public double GetBalance() { return balance; }
        public void SetAccountNumber(string accountNumber) 
        {
            if (accountNumber.Length > 12 || accountNumber.Length < 12)
            {
                Console.WriteLine("One needs to provide only 12 digits for account number");
                return;
            }
            else if (this.accountNumber != null && this.accountNumber.Length == 15)
            {
                Console.WriteLine("Account number can't be changed once given");
            }
            else
            {
                for(int i = 0;i < accountNumber.Length;i++) 
                {
                    if (!Char.IsDigit(accountNumber[i]))
                    {
                        Console.WriteLine("Account number should only contain digits");
                    }
                }
            }
            this.accountNumber = "SBI";
            this.accountNumber += accountNumber;
            Console.WriteLine("Sucessfully create account number : " + this.accountNumber);
        }
        public string GetAccountNumber() 
        {
            if(this.accountNumber == null)
            {
                Console.WriteLine("Please first make the account Number");
            }
            return this.accountNumber;
        }
    }
}
