using System;
using System.Globalization;

namespace _002Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario p1 = new Funcionario();
            Funcionario p2 = new Funcionario();

            Console.WriteLine();
            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double med = (p1.Salario + p2.Salario) / 2;

            Console.WriteLine("Salário médio = " + med.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
