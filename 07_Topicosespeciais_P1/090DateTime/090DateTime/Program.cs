using System;
using System.Globalization;

namespace _090DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1);
            Console.WriteLine();
            Console.WriteLine(d1.Ticks);
            Console.WriteLine();

            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

            Console.WriteLine(d2);
            Console.WriteLine();
            Console.WriteLine(d3);
            Console.WriteLine();
            Console.WriteLine(d4);
            Console.WriteLine();

            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.UtcNow;

            Console.WriteLine(d5);
            Console.WriteLine();
            Console.WriteLine(d6);
            Console.WriteLine();
            Console.WriteLine(d7);
            Console.WriteLine();

            DateTime d8 = DateTime.Parse("2000-08-15");
            DateTime d10 = DateTime.Parse("2000-08-15 13:05:58");

            DateTime d11 = DateTime.Parse("15/08/2000");
            DateTime d12 = DateTime.Parse("15/08/2000 13:08:58");

            Console.WriteLine(d8);
            Console.WriteLine();
            Console.WriteLine(d10);
            Console.WriteLine();
            Console.WriteLine(d11);
            Console.WriteLine();
            Console.WriteLine(d12);
            Console.WriteLine();

            DateTime d13 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d14 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d13);
            Console.WriteLine();
            Console.WriteLine(d14); 

            Console.WriteLine();
        }
    }
}
