using System;
using System.Globalization;

namespace _055Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Tv", 500.00, 10);

            p.SetNome("Tv 4K");
            
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
            Console.WriteLine();
        }
    }
}
