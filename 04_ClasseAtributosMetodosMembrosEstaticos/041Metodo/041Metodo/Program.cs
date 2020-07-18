using System;
using System.Globalization;

namespace _041Metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double xArea = x.Area();

            double yArea = y.Area();

            Console.WriteLine("Area de x = " + xArea.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de y = " + yArea.ToString("F4", CultureInfo.InvariantCulture));

            if (xArea > yArea) Console.WriteLine("Maior área: X");
            else Console.WriteLine("Maior área: Y");
        }
    }
}
