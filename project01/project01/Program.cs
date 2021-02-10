using System;

namespace project01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person x, y;
            Employee a, b;

            x = new Person();
            y = new Person();

            a = new Employee();
            b = new Employee();

            Console.WriteLine("Entre com os dados da primeira pessoa");
            x.Name = Console.ReadLine();
            x.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados da segunda pessoa");
            y.Name = Console.ReadLine();
            y.Age = int.Parse(Console.ReadLine());

            if(x.Age > y.Age)
                Console.WriteLine("Pessoa mais velha: " + x.Name);
            else
                Console.WriteLine("Pessoa mais velha: " + y.Name);

            Console.WriteLine("-----------another program--------------");
            
            Console.WriteLine("Entre com os dados do primeiro funcionario");
            a.Name = Console.ReadLine();
            a.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados do segundo funcionario");
            b.Name = Console.ReadLine();
            b.Salary = double.Parse(Console.ReadLine());

            double media = (b.Salary + a.Salary) / 2;

            Console.WriteLine("Salário Medio = " + media);
        }
    }
}
