using System;
using _125Heranca.Entities;
using System.Globalization;

namespace _125Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8810, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);
        }
    }
}
