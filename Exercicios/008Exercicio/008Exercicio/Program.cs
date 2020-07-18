using System;

namespace _008Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Verificar senha!");
            Console.WriteLine("2 - Ler coordenadas!");
            Console.WriteLine("3 - Posto de gasolina!");
            Console.WriteLine();
            int exe = int.Parse(Console.ReadLine());

            if (exe == 1)
            {
                Console.WriteLine("Introduza a senha!");
                int senha = int.Parse(Console.ReadLine());

                while (senha != 2002)
                {
                    Console.WriteLine("Senha Inválida");
                    Console.WriteLine();
                    Console.WriteLine(("Introduza a senha novamente!"));
                    senha = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Acesso Permitido");
                Console.WriteLine();
            }
            else if (exe == 2)
            {
                Console.WriteLine("Introduza 2 coordenadas (X,Y) separadas por um espaço!");
                string[] coordenada = Console.ReadLine().Split(' ');
                int x = int.Parse(coordenada[0]);
                int y = int.Parse(coordenada[1]);

                while (x !=0 && y !=0)
                {
                    
                    if (x == 0 && y == 0) Console.WriteLine("Origem");
                    else if (x > 0 && y > 0) Console.WriteLine("Primeiro");
                    else if (x < 0 && y > 0) Console.WriteLine("Segundo");
                    else if (x < 0 && y < 0) Console.WriteLine("Terceiro");
                    else Console.WriteLine("Quarto");

                    coordenada = Console.ReadLine().Split(' ');
                    x = int.Parse(coordenada[0]);
                    y = int.Parse(coordenada[1]);
                }
             }
            else
            {
                Console.WriteLine("COMBUSTÍVEL");
                Console.WriteLine(" 1 - Álcool");
                Console.WriteLine(" 2 - Gasolina");
                Console.WriteLine(" 3 - Diesel");
                Console.WriteLine();
                Console.WriteLine(" 4 - PARA TERMINAR - FIM");
                Console.WriteLine();
                Console.WriteLine("Qual o tipo de combustível abastecido");

                int tipo = int.Parse(Console.ReadLine());

                int alcool = 0, gasolina = 0, diesel = 0;


                while (tipo != 4)
                {
                    if (tipo == 1) alcool = alcool + 1;
                    else if (tipo == 2) gasolina = gasolina + 1;
                    else if (tipo == 3) diesel = diesel + 1;

                    Console.WriteLine("Qual o tipo de combustível abastecido");
                    tipo = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();
                Console.WriteLine("MUITO OBRIGADO");
                Console.WriteLine("Alcool:   " + alcool);
                Console.WriteLine("Gasolina: " + gasolina);
                Console.WriteLine("Diesel:   " + diesel);
                Console.WriteLine();
            }
        }
    }
}
