using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_Fix
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return (2 * Largura) + (2 * Altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura,2) + Math.Pow(Altura,2));
        }

        public override string ToString()
        {
            return "AREA = "
                    + Area().ToString("F2", CultureInfo.InvariantCulture)
                    + " PERIMETRO = "
                    + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                    + " DIAGONAL = "
                    + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
