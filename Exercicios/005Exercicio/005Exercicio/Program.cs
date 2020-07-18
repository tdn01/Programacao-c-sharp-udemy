using System;
using System.Globalization; 

namespace _005Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, qtd1, qtd2;
            double prc1, prc2, res;
            string[] valores;

            Console.WriteLine("Digite o código o número e o valor unitário da peça 1 ");
            valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qtd1 = int.Parse(valores[1]);
            prc1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código o número e o valor unitário da peça 2 ");
            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qtd2 = int.Parse(valores[1]);
            prc2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            res = qtd1 * prc1 + qtd2 * prc2;

            Console.WriteLine("VALOR A PAGAR: EUR " + res.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
