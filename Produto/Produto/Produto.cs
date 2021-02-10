using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Produto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque( )
        {
            return  Preco * Quantidade;
        }

        public  void AdicionaProdutos( int qte )
        {
            Quantidade += qte;
        }

        public  void RemoveProdutos (int qte)
        {
            Quantidade -= qte;
        }

        public override string ToString()
        {
            return Nome 
                + ", $ " + 
                Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                +Quantidade
                + " unidade(s), Total: $ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
