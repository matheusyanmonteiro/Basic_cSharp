using System;

namespace Encapsulamento_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("diego");

            Console.WriteLine(p.Nome);

            p.Nome = "TV";

            Console.WriteLine(p.Nome);

        }
    }
}
