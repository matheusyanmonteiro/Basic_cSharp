using System;
using System.Globalization;

namespace Exercicio_Fix
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo a = new Retangulo();

            Console.WriteLine("Coloque as informações do retangulo ----");
            Console.Write("Altura: ");
            a.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Largura: ");
            a.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("DADOS do Funcionario ");
            Funcionario b = new Funcionario();
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            b.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            b.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine(b);
            Console.Write("Digite a porcentagem para aumentar o salario:");
            double pct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.AumentaSalario(pct);
            Console.WriteLine(b);
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("--------------- DADOS DO ALUNO ------------------");
            Aluno c = new Aluno();
            Console.Write("Nome do Aluno: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            c.Nota1 = int.Parse(Console.ReadLine());
            c.Nota2 = int.Parse(Console.ReadLine());
            c.Nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine(c);
            


        }
    }
}
