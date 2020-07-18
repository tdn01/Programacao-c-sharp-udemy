using System;
using System.Globalization;

namespace _25_ExercicioFicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o se nome completo");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua cassa?");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("entre seu último nome, idade e altura (mesma linha):");
            string[] n2 = Console.ReadLine().Split(' ');
            string a = n2[0];
            int b = int.Parse(n2[1]);
            double c = double.Parse(n2[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(n1);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
