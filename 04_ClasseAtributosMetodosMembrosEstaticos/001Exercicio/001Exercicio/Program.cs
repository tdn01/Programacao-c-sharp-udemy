using System;

namespace _001Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa P1 = new Pessoa();
            Pessoa P2 = new Pessoa();

            Console.WriteLine();
            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            P1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            P1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            P2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            P2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (P1.Idade > P2.Idade) Console.WriteLine("Pessoa mais velha: " + P1.Nome);
            else Console.Write("Pessoa mais velha: " + P2.Nome);
            Console.WriteLine();
        }
    }
}
