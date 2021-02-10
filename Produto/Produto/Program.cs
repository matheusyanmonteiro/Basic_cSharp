using System;
using System.Globalization;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com o dado do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------- dados ----------------------");
            Console.Write("Dados do produto: " + p);
            Console.WriteLine();

            Console.WriteLine("----------------------- END --------------------");

            Console.Write("Digite o numero de produtos a ser adcionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionaProdutos(qte);

            Console.WriteLine("--------------------------- dados ----------------------");
            Console.Write("Dados do produto: " + p);
            Console.WriteLine();

            Console.WriteLine("----------------------- END --------------------");

            Console.Write("Digite o numero de produtos a ser removidos no estoque: ");
            int rqte = int.Parse(Console.ReadLine());
            p.RemoveProdutos(rqte);

            Console.WriteLine("--------------------------- dados ----------------------");
            Console.Write("Dados do produto: " + p);
            Console.WriteLine();

            Console.WriteLine("----------------------- END --------------------");


        }
    }
}
