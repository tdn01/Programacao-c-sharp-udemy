using System;
using System.Globalization;

namespace _047MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine();
            Console.WriteLine("Circunfência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
