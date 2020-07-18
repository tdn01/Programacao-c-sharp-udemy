using System;
using System.Globalization;

namespace _007Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int exe , n1, n2, res;
            double res1, res2;
            string[] valores;            
            
            Console.WriteLine("1 - Informar se o número é negativo ou não!");
            Console.WriteLine("2 - Informar se o número é par ou ímpar!");
            Console.WriteLine("3 - Informar se os números são multiplos entre si!");
            Console.WriteLine("4 - Calcular a duração de um jogo");
            Console.WriteLine("5 - Calcular conta a pagar!");
            Console.WriteLine("6 - Informar em qual dos intervalos o valor se econtra!");
            Console.WriteLine("7 - Ler 2 valores com uma casa decimal!");
            Console.WriteLine("8 - Inserir valor do salário!");
            Console.WriteLine();

            exe = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // 1 - Informar se o número é negativo ou não!
            if (exe == 1)
            {
                Console.WriteLine("Digite um número inteiro!");
                n1 = int.Parse(Console.ReadLine());

                if (n1 >= 0) Console.WriteLine("NÃO NEGATIVO");
                else         Console.WriteLine("NEGATIVO");
            }
            // 2 - Informar se o número é par ou ímpar!
            else if (exe == 2)
            {
                Console.WriteLine("Digite um número inteiro!");
                Console.WriteLine();
                n1 = int.Parse(Console.ReadLine());

                if (n1 % 2 == 0) Console.WriteLine("Este número é Par!");
                else             Console.WriteLine("Este número é Ímpar!");
            }
            // 3 - Informar se os números são multiplos entre si!
            else if (exe == 3)
            {               
                Console.WriteLine("Digite 2 números inteiros, separador por um espaço!");                
                valores = Console.ReadLine().Split(' ');
                Console.WriteLine();

                n1 = int.Parse(valores[0]);
                n2 = int.Parse(valores[1]);

                if (n1 % n2 == 0 || n2 % n1 == 0) Console.WriteLine("São Multíplos!");
                else                              Console.WriteLine("Não são Multíplos");
            }
            // 4 - Calcular a duração de um jogo
            else if (exe == 4)
            {
                Console.WriteLine("Indique a hora ínicial e a hora final separado por um espaço");
                valores = Console.ReadLine().Split(' ');
                Console.WriteLine();

                n1 = int.Parse(valores[0]);
                n2 = int.Parse(valores[1]);

                if (n1 >= n2) res = 24 - n1 + n2;
                else res = n2 - n1;
                
                Console.WriteLine("O JOGO DUROU " + res + " HORA(S)");
                Console.WriteLine();
            }
            // 5 - Calcular conta a pagar!
            else if (exe == 5)
            {                
                Console.WriteLine(" CODIGO  ESPECIFICAÇÃO     PREÇO");
                Console.WriteLine("   1     Cachorro Quente   EUR 4.00");
                Console.WriteLine("   2     X-Salada          EUR 4.50");
                Console.WriteLine("   3     X-Bacon           EUR 5.00");
                Console.WriteLine("   4     Torrada Simples   EUR 2.00");
                Console.WriteLine("   5     Refrigerante      EUR 1.50");
                Console.WriteLine();
                Console.WriteLine("Digite o código e a quantidade do produto separado por um espaço!");
                valores = Console.ReadLine().Split(' ');
                Console.WriteLine();

                n1 = int.Parse(valores[0]);
                n2 = int.Parse(valores[1]);

                if (n1 == 1) res1 = n2 * 4.00;
                else if (n1 == 2) res1 = n2 * 4.50;
                else if (n1 == 3) res1 = n2 * 5.00;
                else if (n1 == 4) res1 = n2 * 2.00;
                else res1 = n2 * 1.50;

                Console.WriteLine("Total: EUR " + res1.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
            }
            // 6 - Informar em qual dos intervalos o valor se econtra!
            else if (exe == 6)
            {
                Console.WriteLine("Digite um valor qualquer!");
                res1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                if (res1 < 0 || res1 > 100) Console.WriteLine("Fora de Intervalor");
                else if (res1 <= 25) Console.WriteLine("Intervalo [0,25]");
                else if (res1 <= 50) Console.WriteLine("Intervalo (25,50]");
                else if (res1 <= 75) Console.WriteLine("Intervalo (50,75]");
                else Console.WriteLine("Intervalo (75,100]");
                Console.WriteLine();
            }
            // 7 - Ler 2 valores com uma casa decimal!
            else if (exe == 7)
            {
                Console.WriteLine("Digite 2 valores (x,y) com uma casa decimal separados por um espaço!");
                valores = Console.ReadLine().Split(' ');
                Console.WriteLine();

                res1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                res2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

                if (res1 == 0 && res2 == 0) Console.WriteLine("Origem");
                else if (res1 > 0 && res2 > 0) Console.WriteLine("Q1");
                else if (res1 < 0 && res2 > 0) Console.WriteLine("Q2");
                else if (res1 < 0 && res2 < 0) Console.WriteLine("Q3");
                else Console.WriteLine("Q4");
                Console.WriteLine();
            }
            // 8 - Inserir valor do salário!
            else
            {
                res2 = 0;
                Console.WriteLine("Valor do salário?");
                res1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (res1 <= 2000.00) Console.WriteLine("Isento");
                else if (res1 <= 3000.00) res2 = (res1 - 2000.00) * 0.08;
                else if (res1 <= 4500.00) res2 = ((res1 - 3000.00) * 0.18) + ((res1 - 2000.00 - (res1 - 3000.00)) * 0.08);                 
                else res2 = ((res1 - 4500.00) * 0.28) + (((res1 - 3000.00) - (res1 - 4500.00)) * 0.18) + (((res1 - 2000.00) - (res1 - 3000.00)) * 0.08);                 

                if (res2 != 0) Console.WriteLine("EUR " + res2.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
