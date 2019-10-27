using System;
using System.Collections.Generic;
using System.Linq;
using TesteGeografia.TesteGeografia;

namespace TesteGeografia
{
    public static class States
    {
        public static List<City> Capitais = new List<City>();
        public static List<City> Cities = new List<City>();

        public static City GetCityByName(string nome)
        {
            var capital = Capitais.FirstOrDefault(f => f.Name.Equals(nome));
            if (capital != null)
                return capital;

            var city = Cities.FirstOrDefault(f => f.Name.Equals(nome));
            if (city != null)
                return city;
            
            throw new Exception("Não é possivel selecionar a cidade desejada");
        }

        public static void CapitaisSeed()
        {
            var curitiba = new City(1, "Curitiba", "PR");
            var florianopolis = new City(2,  "Florianopolis", "SC");
            var portoAlegre = new City(3, "PortoAlegre", "RS");

            Capitais.Add(curitiba);
            Capitais.Add(florianopolis);
            Capitais.Add(portoAlegre);
        }


        public static void CitySeed()
        {
            var Maringa = new City("Maringá", 1);
            var Londrina = new City("Londrina", 1);
            var pinhais = new City("Pinhais", 1);
            var chapeco = new City("Chapeco", 2);
            var joinvile = new City("Joinvile", 2);
            var blumenau = new City("Blumenau", 2);
            var gramado = new City("Gramado", 3);

            Cities.Add(Maringa);
            Cities.Add(Londrina);
            Cities.Add(pinhais);
            Cities.Add(chapeco);
            Cities.Add(joinvile);
            Cities.Add(blumenau);
            Cities.Add(gramado);
        }
    }
}