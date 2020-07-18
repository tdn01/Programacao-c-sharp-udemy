using System;

namespace _093TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t);

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine();

            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);
            Console.WriteLine();

            TimeSpan s1 = new TimeSpan(1, 30, 10);
            TimeSpan s2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = s1.Add(s2);
            TimeSpan dif = s1.Subtract(s2);
            TimeSpan mult = s2.Multiply(2.0);
            TimeSpan div = s2.Divide(2.0);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

            Console.WriteLine();
        }
    }
}
