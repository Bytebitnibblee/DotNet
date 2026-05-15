using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnException
{
    internal class Program
    {
        int balance;
        public void amountWithdraw(int a)
        {
            try
            {
                if (a > balance)
                {
                    throw new LessBalance(a, balance);
                    balance = balance - a;
                    Console.WriteLine("Amount Withdraw your balance" + balance);
                }
            }
            catch (LessBalance e)
            {
                Console.WriteLine("Enter Amount Less Than:" + balance);
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Enter the balance");
            obj.balance = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter withdrawn amount");
            int a = int .Parse(Console.ReadLine());

            obj.amountWithdraw(a);
        }
        class Lessbalance : Exception
        {
            public Lessbalance(int a, int b)
            {
                Console.WriteLine("Your balance is " + b + "and you want to withdraw" + a);
            }
        }
    }
}
