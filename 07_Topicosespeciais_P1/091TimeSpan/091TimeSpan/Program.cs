using System;

namespace _091TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);

            Console.WriteLine();
            Console.WriteLine(t1);
            Console.WriteLine();
            Console.WriteLine(t1.Ticks);
            Console.WriteLine();

            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);
            TimeSpan t4 = new TimeSpan(2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);


            Console.WriteLine(t2);
            Console.WriteLine();
            Console.WriteLine(t3);
            Console.WriteLine();
            Console.WriteLine(t4);
            Console.WriteLine();
            Console.WriteLine(t5);
            Console.WriteLine();
            Console.WriteLine(t6);
            Console.WriteLine();

            TimeSpan t7 = TimeSpan.FromDays(1.5);
            TimeSpan t8 = TimeSpan.FromHours(1.5);
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t7);
            Console.WriteLine();
            Console.WriteLine(t8);
            Console.WriteLine();
            Console.WriteLine(t9);
            Console.WriteLine(); Console.WriteLine(t10);
            Console.WriteLine();
            Console.WriteLine(t11);
            Console.WriteLine();
            Console.WriteLine(t12);

            Console.WriteLine();
        }
    }
}
