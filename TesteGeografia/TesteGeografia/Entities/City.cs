namespace TesteGeografia
{
    public class City
    {
        public string Name { get; set; }
        public bool Capital { get; set; }

        public City(string nome, bool capital = false)
        {
            Name = nome;
            Capital = capital;
        }
        
        
    }
}