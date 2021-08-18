using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double Media()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public void Aprovacao()
        {
            Console.WriteLine("NOTA FINAL = " + Media());
            if (Media() >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                double media = 60 - Media();
                Console.WriteLine("FALTARAM " + media + " PONTOS");
            }
        }


    }
}
