using System;
using System.Globalization;

namespace static_members
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares voce vai comprar ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double doll = ConversorDeMoeda.CompraDeDolar(dolar, cotacao);

            Console.WriteLine("Valor a ser pago em reais = "+ doll.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
