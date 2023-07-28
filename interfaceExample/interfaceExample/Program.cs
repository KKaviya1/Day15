using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace interfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount account = null;
            Console.WriteLine("choose account type");
            Console.WriteLine("1.Savings\n2.Current");
            int acType = int.Parse(Console.ReadLine());

            switch (acType)
            {
                case 1:
                    {
                        account = new SavingAccount();
                        break;
                    }

                case 2:
                    {
                        account = new CurrentAccount();
                        break;
                    }
                default:
                    {
                        return;
                    }
            }

            Console.WriteLine("choose operation");
            Console.WriteLine("1.Balance\n2.Deposit\n3.Withdraw");
            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    {
                        Console.WriteLine(account.Balance);
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine(account.Deposit(1200));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(account.WithDraw(1200));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid operation");
                        break;
                    }
            }
        }
    }
}