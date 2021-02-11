using System;

namespace project03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int value;
            int _in = 0;
            int _out = 0;

            for(int i = 0; i < number; i++)
            {
                value = int.Parse(Console.ReadLine());
                if (value >= 10 && value <= 20)
                    _in++;
                else
                    _out++;
            }
            Console.WriteLine(_in + " in");
            Console.WriteLine(_out + " out");
        }
    }
}
