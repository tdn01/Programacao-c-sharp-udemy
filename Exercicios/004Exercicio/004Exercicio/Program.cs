using System;
using System.Globalization;

namespace _004Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, rend;

            Console.Write("Digite número de funcionário = ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite número de horas trabalhadas = ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor que recebe por hora = ");
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            rend = n2 * n3;

            Console.WriteLine("NUMBER = " + n1);
            Console.WriteLine("SALARY = U$ " + rend.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
