using System;

namespace _0026OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 && 4 != 5; //False
            bool c2 = 2 > 3 || 4 != 5; // True 
            bool c3 = !(2 > 3) && 4 != 5; // True

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine("-------------------------------");

            bool c4 = 10 < 5; //False
            bool c5 = c2 || c3 && c4; // True

            Console.WriteLine(c4);
            Console.WriteLine(c5);
        }
    }
}
