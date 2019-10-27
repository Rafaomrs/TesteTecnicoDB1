using System;
using System.Reflection.Metadata.Ecma335;
using TesteGeografia.TesteGeografia;

namespace TesteGeografia
{
    class Program
    {

        static void Main(string[] args)
        {
            States.CapitaisSeed();
            States.CitySeed();

            Console.WriteLine("Digite o nome da cidade: ");
            var nome = Console.ReadLine();

           var city = States.GetCityByName(nome);

           if (city.IsCapital(city))
           { 
               Console.WriteLine("Eh uma capital!!");
               Console.WriteLine(city.GetState(city));
           }
           else
           {
               Console.WriteLine("não eh uma capital!!");
               Console.WriteLine($"Pertence a {city.GetState(city)}");
           }
           
        }
    }
}
