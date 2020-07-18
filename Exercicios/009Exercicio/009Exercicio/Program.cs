using System;
using System.Globalization;

namespace _009Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("     **** SELECIONE UMA OPÇÃO ****");
            Console.WriteLine("     -----------------------------");
            Console.WriteLine("     1 - Mostrar números ímpares");
            Console.WriteLine("     2 - Valores In/Out");
            Console.WriteLine("     3 - Média Ponderada");
            Console.WriteLine("     4 - N pares de números e divisão do primeiro pelo segundo");
            Console.WriteLine("     5 - Inserir uma valor e calcular o fatorial");
            Console.WriteLine("     6 - Ler N e calcular todos os seu divisores");
            Console.WriteLine("     7 - Mostrar N linhas de 1 até N");
            Console.WriteLine("     8 - EXIT");
            Console.WriteLine("     -----------------------------");
            Console.Write("     Opçãp: ");
            int exe = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (exe != 8)
            {
                // 1 - Mostrar números ímpares
                if (exe == 1)
                {
                    Console.Write("     Digite um número inteiro entre 1 e 1000: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    for (int i = 1; i <= n; i++)
                    {
                        if (i % 2 != 0) Console.WriteLine("     " + i);
                    }
                }
                // 2 - Valores In / Out
                else if (exe == 2)
                {
                    int count_in = 0;
                    int count_out = 0;

                    Console.Write("     Quantos valores vais digitar? ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    for (int i = 1; i <= n; i++)
                    {
                        Console.Write("     Número #{0}: ", i);
                        int x = int.Parse(Console.ReadLine());

                        if (x >= 10 && x <= 20) count_in = count_in + 1;
                        else count_out = count_out + 1;
                    }

                    Console.WriteLine();
                    Console.WriteLine("     " + count_in + " in");
                    Console.WriteLine("     " + count_out + " out");
                }
                // 3 - Média Ponderada
                else if (exe == 3)
                {
                    Console.Write("     Número casos de teste? ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine("     Digite 3 valores separador um um espaço para calcular a média!"); ;
                        Console.Write("     ");
                        string[] valores = Console.ReadLine().Split(' ');
                        double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                        double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
                        double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

                        double med = (a * 2 + b * 3 + c * 5) / 10;

                        Console.WriteLine("     Média Ponderada (a 2, b 3, c 5) = " + med.ToString("F1", CultureInfo.InvariantCulture));
                        Console.WriteLine();
                    }

                }
                // N pares de números e divisão do primeiro pelo segundo
                else if (exe == 4)
                {
                    Console.Write("     Digite o número de repetições! ");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= n; i++)
                    {
                        Console.Write("     2 números separados por um espaço! ");
                        string[] valores = Console.ReadLine().Split(' ');
                        int a = int.Parse(valores[0]);
                        int b = int.Parse(valores[1]);

                        if (b == 0) Console.WriteLine("     Divisão Impossível");
                        else
                        {
                            double div = (double)a / b;
                            Console.WriteLine("     Número de pares " + div.ToString("F1", CultureInfo.InvariantCulture));
                        }
                        Console.WriteLine();
                    }
                }
                // 5 - Inserir uma valor e calcular o fatorial
                else if (exe == 5)
                {
                    Console.Write("     Calcular o fatorial de ");
                    int n = int.Parse(Console.ReadLine());

                    int fat = 1;

                    for (int i = 1; i <= n; i++)
                    {
                        fat = fat * i;
                    }
                    Console.WriteLine("     Fatorial de !" + n + " é " + fat);
                }
                // 6 - Ler N e calcular todos os seu divisores
                else if (exe == 6)
                {
                    Console.Write("     Inserir um número inteiro ");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0) Console.WriteLine("     " + i);
                    }
                }
                // 7 - Mostrar N linhas de 1 até N
                else if (exe == 7)
                {
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= n; i++)
                    {

                        int primeiro = i;
                        int segundo = i * i;
                        int terceiro = i * i * i;
                        Console.WriteLine($"{primeiro} {segundo} {terceiro}");
                    }
                }
                // Opção indisponível                
                else Console.WriteLine("     Opção Indisponível, tente novamente");

                Console.WriteLine();
                Console.Write("     Opçãp: ");
                exe = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}
