using System;

namespace first_project
{
    class exercise01
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number1 = int.Parse(Console.ReadLine());
            int aux;

           if (number > number1)
            {
                aux = ((-1) * (number - 24)) + number1;
                Console.WriteLine("O JOGO DUROU " + aux + " HORAS(S)");
            } else if (number1 < number)
            {
                aux = (number1 - number);
                Console.WriteLine("O JOGO DUROU " + aux + " HORAS(S)");
            } else if (number == 0 && number1 == 0)
            {
                Console.WriteLine("O JOGO DUROU 24 HORAS(S)");
            }
            else
            {
                aux = (-1) * (number - number1);
                Console.WriteLine("O JOGO DUROU " + aux + " HORA(S)");
            }

        }
    }
}
