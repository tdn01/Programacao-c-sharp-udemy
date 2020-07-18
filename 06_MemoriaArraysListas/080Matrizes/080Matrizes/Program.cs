using System;

namespace _080Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Entre numero de linhas da matriz: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite 3 valores por cada linha separado por espaço em branco");
            Console.WriteLine();

            int[,] mat = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                int l = i + 1;
                
                Console.Write("Linha #" + l +": ");
                string[] values = Console.ReadLine().Split(" ");

                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine();

            Console.Write("Main diagonal: ");

            for(int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();            

            int neg = 0;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        neg++;
                    }
                }
            }
            Console.Write("Negative numbers = " + neg);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
