using System;
using System.Globalization;

namespace _088ExpressaoCondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            double percentagem = (preco < 20.0) ? 0.1 : 0.05;

            Console.WriteLine("Preço * precentagem de desconto " + percentagem + " = "  + desconto);
            Console.WriteLine();
        }
    }
}
