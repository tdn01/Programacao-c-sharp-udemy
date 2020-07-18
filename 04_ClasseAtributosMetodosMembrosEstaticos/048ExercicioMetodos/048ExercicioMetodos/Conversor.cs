using System;
using System.Collections.Generic;
using System.Text;

namespace _048ExercicioMetodos
{
    class Conversor
    {
        public static double Iof = 6.0;

        public static double DolarReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total * (1 + (Iof / 100));
        }
    }
}
