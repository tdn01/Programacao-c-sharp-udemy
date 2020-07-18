using System;

namespace _087SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("DIAS da SEMANA");
            Console.WriteLine(" 1 - Sunday");
            Console.WriteLine(" 2 - Monday");
            Console.WriteLine(" 3 - Tuesday");
            Console.WriteLine(" 4 - Wednesday");
            Console.WriteLine(" 5 - Thursday");
            Console.WriteLine(" 6 - Friday");
            Console.WriteLine(" 7 - Saturday");
            Console.WriteLine();
            Console.Write("Dia da semana: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string day;

            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;

                case 2:
                    day = "Monday";
                    break;

                case 3:
                    day = "Tuesday";
                    break;

                case 4:
                    day = "Wednesday";
                    break;

                case 5:
                    day = "Thursday";
                    break;

                case 6:
                    day = "Friday";
                    break;

                case 7:
                    day = "Saturday";
                    break;

                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine("Day: " + day);
            Console.WriteLine();
        }
    }
}
