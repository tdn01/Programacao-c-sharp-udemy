using System;

namespace _073ModificadoresParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculador.Triple(ref a);
            Console.WriteLine(a); 
        }
    }
}
