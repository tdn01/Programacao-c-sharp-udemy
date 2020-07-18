using System;

namespace _0027EstruturaCondicional_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estrutura Condicional Simple

            int x = 10;
            Console.WriteLine("Bom dia");
            if (x > 5) {
                Console.WriteLine("Boa tarde");
            }
                Console.WriteLine("Boa noite");

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            // Estrutura Condicional Composta

            Console.WriteLine("Entre com um número inteiro:  ");
            int y = int.Parse(Console.ReadLine());

            if(y % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            // estrutura Condicional Encadeada

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (hora < 12)      Console.WriteLine("Bom dia!");
            else if (hora < 18) Console.WriteLine("Boa tarde!");
            else                Console.WriteLine("Boa noite!");
            

            Console.WriteLine();
        }
    }
}
