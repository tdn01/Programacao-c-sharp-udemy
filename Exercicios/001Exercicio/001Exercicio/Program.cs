using System;

namespace _001Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor!");
            int n1 = int.Parse(Console.ReadLine());            

            Console.WriteLine(("Digite o segundo valor!")); 
            int n2 = int.Parse(Console.ReadLine());
            
            int s1 = n1 + n2;

            Console.WriteLine("SOMA = " + s1);
            Console.WriteLine();                    

        }
    }
}
