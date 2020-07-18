using System;
using System.Globalization;

namespace _002Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio!");
            double r1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double area = pi * r1 * r1;

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
