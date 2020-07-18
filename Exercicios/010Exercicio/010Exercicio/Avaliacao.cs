using System;
using System.Collections.Generic;
using System.Text;


namespace _010Exercicio
{
    class Avaliacao
    {
        public string nome;
        public double n1, n2, n3;

        public double NotaFinal()
        {
            return n1 + n2 + n3;
        }

        public bool Resultado()
        {
            if (NotaFinal() >= 60.0)
                return true;
            else
            {
                return false;
            }
        }

        public double EmFalta()
        {
            if (Resultado())
            {
                return 0.0;
            }                
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}
