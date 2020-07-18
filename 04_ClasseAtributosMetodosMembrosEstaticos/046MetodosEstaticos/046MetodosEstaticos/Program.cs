using System;
using System.Globalization;

namespace _046MetodosEstaticos
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Volume:  " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }

        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
        }
    }
}
