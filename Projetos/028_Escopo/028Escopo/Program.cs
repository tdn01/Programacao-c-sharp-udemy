using System;

namespace _028Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, desconto;

            preco = double.Parse(Console.ReadLine());
            desconto = 0;

            if(preco > 100.0)
            {
                desconto = preco * 0.1;                    
            }

            Console.WriteLine(desconto);
        }
    }
}
