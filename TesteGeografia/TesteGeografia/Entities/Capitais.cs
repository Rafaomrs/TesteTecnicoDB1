using System;
using System.Collections.Generic;

namespace TesteGeografia
{
    public class Capitais
    {
        public List<City> Cities { get; set; }
   
        public string EstadoPR { get; set; }
        public string EstadoSC { get; set; }
        public string EstadoRS { get; set; }

        /*------------------------------------------------------------------------------------------------------------------------------------------*/
        //Construtores.
        public Capitais()
        {

        }

        public Capitais(string cidade) : this()
        {
            Capital(cidade);
            PertenceEstado(cidade);

        }

        /*------------------------------------------------------------------------------------------------------------------------------------------*/
        // Métods.
        public void Capital(string cidade)
        {
            if (cidade == "Curitiba")
            {
                CapitalPR = cidade;
                Console.WriteLine("É capital!");
            }
            else if (cidade == "Porto Alegre")
            {
                CapitalRS = cidade;
                Console.WriteLine("É capital!");
            }
            else if (cidade == "Florianópolis")
            {
                CapitalSC = cidade;
                Console.WriteLine("É capital!");
            }
            else
            {
                Console.WriteLine("Não é Capital");
            }
        }

        /*------------------------------------------------------------------------------------------------------------------------------------------*/
        // Métods
        public void PertenceEstado(string cidade)
        {
            if (cidade == "Curitiba" || cidade == "Maringá" || cidade == "Londrina" || cidade == "Pinhais")
            {
                EstadoPR = cidade;
                Console.WriteLine("Pertence ao PR!");
            }
            else if (cidade == "Florianópolis" || cidade == "Chapecó" || cidade == "Joinville" || cidade == "Blumenau")
            {
                EstadoSC = cidade;
                Console.WriteLine("Pertence ao SC!");
            }
            else if (cidade == "Porto Alegre" || cidade == "Gramado")
            {
                EstadoRS = cidade;
                Console.WriteLine("Pertence ao RS!");
            }
            else
            {
                Console.WriteLine("Estado desconhecido.");
            }
        }
    }
}
