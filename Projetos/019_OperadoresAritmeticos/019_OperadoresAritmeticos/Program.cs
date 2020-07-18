using System;

namespace _019_OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            //int n1 = 3 + 4 * 2;           
            //int n2 = (3 + 4) * 2;
            //int n3 = 17 % 3;
            //double n4 = 10 / 8.0;

            //Console.WriteLine();
            //Console.WriteLine(n1);           
            //Console.WriteLine(n2);            
            //Console.WriteLine(n3);            
            //Console.WriteLine(n4);


            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            










            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
