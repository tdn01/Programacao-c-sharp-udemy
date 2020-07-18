using System;

namespace _072ModificadorParamentros
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculador.Sum(2, 3);
            int s2 = Calculador.Sum(2, 4, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
