using System;
using System.Globalization;

namespace _006Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, tri, cir, tra, qua, ret;
            string[] valores;

            Console.WriteLine("digite tres valores com ponto flutuante de dupla percisão: ");
            valores = Console.ReadLine().Split(' ');
            Console.WriteLine();

            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            tri = a * c / 2;
            cir = 3.14159 * c * c;
            tra = (a + b) / 2 * c;
            qua = b * b;
            ret = a * b;

            Console.WriteLine("TRIÂNGULO: " + tri.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + cir.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + tra.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + qua.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + ret.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
