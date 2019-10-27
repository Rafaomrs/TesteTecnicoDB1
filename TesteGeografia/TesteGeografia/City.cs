using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace TesteGeografia
{
    namespace TesteGeografia
    {
        public class City
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool Capital { get; set; }

            public string Alias { get; set; }

            public int? Father { get; set; }

            public City(int id, string nome, string alias, bool capital = true)
            {
                Id = id;
                Name = nome;
                Alias = alias;
                Capital = capital;
            }

            public City(string nome, int? father, bool capital = false)
            {
                Name = nome;
                Father = father;
                Capital = capital;
            }
            
            public bool IsCapital(City city) => States.Capitais.Contains(city) ? true : false;

            public string GetState(City city)
            {
                if(city.Father.HasValue)
                return States.Capitais.First(w => w.Id.Equals(city.Father)).Alias;
                return States.Capitais.First(w => w.Id.Equals(city.Id)).Alias;
            }
        }
    }
}