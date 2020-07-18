using System;

namespace _073ModificadorParametros2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Calculador.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
