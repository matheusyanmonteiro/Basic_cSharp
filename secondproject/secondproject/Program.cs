using System;

namespace secondproject
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = int.Parse(Console.ReadLine());
            int cont1 = 0;
            int cont2 = 0;
            int cont3 = 0;

            while (option != 4)
            {
                if (option == 1)
                {
                    cont1++;
                    option = int.Parse(Console.ReadLine());
                }
                else if (option == 2)
                {
                    cont2++;
                    option = int.Parse(Console.ReadLine());
                }
                else if (option == 3)
                {
                    cont3++;
                    option = int.Parse(Console.ReadLine());
                }
                else
                    option = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + cont1);
            Console.WriteLine("Gasolina: " + cont2);
            Console.WriteLine("Diesel: " + cont3);
        }
    }
}
