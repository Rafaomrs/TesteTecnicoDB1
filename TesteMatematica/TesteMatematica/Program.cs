using System;

namespace TesteMatematica
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Informe um numero!");
            int number = int.Parse(Console.ReadLine());


            if (number % 2 == 0)
            {
                Console.WriteLine("O número é Par");
                Console.WriteLine("O número não é ímpar");
                if (number > 10)
                {
                    Console.WriteLine("O número é maior que 10");
                }
                else
                {
                    Console.WriteLine("O número não é maior que 10");
                }

            }
            else
            {
                Console.WriteLine("O número não é Par");
                Console.WriteLine("O número é ímpar");
                if (number > 10)
                {
                    Console.WriteLine("O número é maior que 10");
                }
                else
                {
                    Console.WriteLine("O número não é maior que 10");
                }
            }


            Console.WriteLine("O Dobro de " + number + " é " + (number + number));
            if (number % number == 0)
            {
                Console.WriteLine("O número é Primo");
            }
            else
            {
                Console.WriteLine("O número não é Primo");
            }
        }
    }
}
