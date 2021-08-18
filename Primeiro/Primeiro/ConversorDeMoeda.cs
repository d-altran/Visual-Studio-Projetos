using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class ConversorDeMoeda
    {

        public static double iof = 6.0;
        public static double Cotacao(double cotacao, double qtde)
        {
            double total = cotacao * qtde;
            return total + total * iof / 100;
            
        }

    }
}
