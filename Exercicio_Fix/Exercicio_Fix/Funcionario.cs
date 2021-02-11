using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_Fix
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

        public void AumentaSalario( double percent)
        {
            SalarioBruto += (percent / 100) * SalarioBruto;
        }

        public override string ToString()
        {
            return "Dados atualizados: "
                    + Nome
                    + ", $ "
                    + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
