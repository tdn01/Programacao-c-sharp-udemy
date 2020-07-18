using System;

namespace _081Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Estrutra Matriz");
            Console.Write("Entre Nº Limhas e Colunas: ");
            string[] lc = Console.ReadLine().Split(' ');
            int ln = int.Parse(lc[0]);
            int cl = int.Parse(lc[1]);

            int[,] mat = new int[ln, cl];

            for(int i = 0; i < ln; i++)
            {
                int l = i + 1;
                Console.Write("Linha #" + l + ": ");
                Console.WriteLine();
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < cl; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }            
            Console.WriteLine();

            Console.Write("Escolha um nº da Matriz: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            for(int i = 0; i < ln; i++)
            {
                for(int j = 0; j < cl; j++)
                {
                    if(mat[i, j] == num)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");

                        if(j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if(j < ln -1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if(i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if(i < cl - 1)
                        {
                            Console.WriteLine("down: " + mat[i + 1, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
