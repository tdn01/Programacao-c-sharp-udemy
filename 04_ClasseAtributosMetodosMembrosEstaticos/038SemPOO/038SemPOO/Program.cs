using System;
using System.Globalization;

namespace _038SemPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2;
            double xArea = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;
            double yArea = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Area de x = " + xArea.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de y = " + yArea.ToString("F4", CultureInfo.InvariantCulture));

            if (xArea > yArea) Console.WriteLine("Maior área: X");
            else Console.WriteLine("Maior área: Y");
        }
    }
}
