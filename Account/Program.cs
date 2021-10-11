using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Account.bonus);
            Account.bonus += 200;
            Account account1 = new Account(150);
            Console.WriteLine(account1.totalSum);
            Account account2 = new Account(1000);
            Console.WriteLine(account2.totalSum);

            Console.ReadKey();
        }
    }
}