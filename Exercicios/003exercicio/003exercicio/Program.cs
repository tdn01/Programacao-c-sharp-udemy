using System;

namespace _003exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, res;
            
            Console.Write("Digite o valor A = ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor B = ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor C = ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor D = ");
            n4 = int.Parse(Console.ReadLine());

            res = n1 * n2 - n3 * n4;

            Console.WriteLine("DIFERENÇA = " + res);
        }
    }
}
