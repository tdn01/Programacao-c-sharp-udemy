using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _010Exercicio
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double percentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * percentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome 
                + ", Eur " 
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
