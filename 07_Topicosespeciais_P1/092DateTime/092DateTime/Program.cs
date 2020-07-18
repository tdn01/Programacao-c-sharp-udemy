using System;

namespace _092DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine();
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine();

            DateTime t = new DateTime(2001, 8, 15, 13, 45, 58);

            string s1 = t.ToLongDateString();
            string s2 = t.ToLongTimeString();
            string s3 = t.ToShortDateString();
            string s4 = t.ToShortTimeString();

            string s5 = d.ToString();

            string s6 = t.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = t.ToString("yyyy-MM-dd HH:mm:ss.fff");


            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine();

            DateTime t2 = t.AddHours(2);
            DateTime t3 = t.AddMinutes(3);
            DateTime t4 = t.AddDays(7);

            Console.WriteLine(t);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine();

            DateTime d1 = new DateTime(2000, 10, 15);
            DateTime d2 = new DateTime(2000, 10, 18);

            TimeSpan dif = d2.Subtract(d1);

            Console.WriteLine(dif);

            Console.WriteLine();
        }
    }
}
