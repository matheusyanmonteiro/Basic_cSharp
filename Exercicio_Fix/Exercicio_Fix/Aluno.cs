using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fix
{
    class Aluno
    {
        public string Nome;
        public int Nota1;
        public int Nota2;
        public int Nota3;
        public int Reprovado;

        public int NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string Aprovado()
        {
            if(NotaFinal() > 60 )
            {
                return "APROVADO";
            }
            else
            {
                Reprovado = 60 - NotaFinal();
                return "REPROVADO\n"
                        + "FALTAM " + Reprovado + " PONTOS";

            }
        }


        public override string ToString()
        {
            return "NOTA FINAL = " +
                NotaFinal()
                +"\n"
                + Aprovado();
        }
    }
}
