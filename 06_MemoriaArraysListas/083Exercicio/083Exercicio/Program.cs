using System;
using System.Collections.Generic;

namespace _083Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.WriteLine();
            Console.Write("O curso A possui quantos alunos? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");

            for(int i = 0; i < n; i++)
            {
                int t = i + 1;
                Console.Write("Digite o #" + t + " código de aluno: ");
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.WriteLine();
            Console.Write("O curso B possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B: ");

            for(int i = 0; i < n; i++)
            {
                int t = i + 1;
                Console.Write("Digite o #" + t + " código de aluno: ");
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }

            Console.WriteLine();
            Console.Write("O curso C possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curos C: ");

            for(int i = 0; i < n; i++)
            {
                int t = i + 1;
                Console.Write("Digite o #" + t + " código do aluno: " );
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }

            Console.WriteLine();
            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);
            Console.Write("Total de Aluno: " + Novo.Count);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
