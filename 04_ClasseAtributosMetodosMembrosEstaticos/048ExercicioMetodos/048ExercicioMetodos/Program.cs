using System;
using System.Globalization;   

namespace _048ExercicioMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Qual a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qantos dólares vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            double result = Conversor.DolarReal(quantidade, cotacao);
            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }


    }
}
