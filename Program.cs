using System;

namespace BankApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount("BOI334556@123","Ram",3600.00);
            b.PrintDetails();
            Console.ReadKey();  

        }
    }
}
