using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceExample
{
    internal class SavingAccount : IAccount
    {
        double sBal;
        public SavingAccount()
        {
            sBal = 20000;
        }
        public double Balance => sBal;
        public double Deposit(double amount)
        {
            sBal += amount;
            return sBal;
        }
        public double WithDraw(double amount)
        {
            if (amount <= sBal)
            {
                if (sBal - amount >= 500)
                {
                    sBal -= amount;
                    Console.WriteLine("Transaction success!!");
                }
                else
                {
                    Console.WriteLine("Minimum balance have to maintain 5000");
                }
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
                Console.WriteLine("Transaction Declined");
            }
            return sBal;
        }
    }
}
