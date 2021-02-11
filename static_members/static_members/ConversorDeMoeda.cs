using System;
using System.Collections.Generic;
using System.Text;

namespace static_members
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.38;

        public static double CompraDeDolar(double c, double q)
        {
            return ((q * c) * Iof) + (q * c);
        }

    }
}
