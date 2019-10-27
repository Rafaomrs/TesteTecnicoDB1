using System;
using System.Linq;

namespace TestePortugues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um texto!");
            Console.WriteLine();

            string text = Console.ReadLine();



            // Contar vogais no texto.
            int vogal = 0;
            char[] caracteres = { 'a', 'á', 'â', 'ã', 'ä', 'à' };

            char[] palavras = text.ToLower().ToCharArray();

            for (int conta = 0; conta < palavras.Length; conta++)
            {
                if (caracteres.Contains(palavras[conta]))
                {
                    vogal++;
                }
            }



            /*------------------------------------------------------------------------------------------------------------------------------------*/

            Console.WriteLine("O texto digitado possui {0} caracteres!", NumeroDeCaractere(text) + TotalDeNumeros(text) + TotalDeEspacos(text));
            Console.WriteLine("O texto digitado possui {0} espaços em branco!", TotalDeEspacos(text));
            Console.WriteLine("O texto digitado possui {0} letras vogais .", vogal);
        }

            /*------------------------------------------------------------------------------------------------------------------------------------*/


        // Contar números de caractere no texto.
        public static int NumeroDeCaractere(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    count++;
                }

            }
            return count;
        }

        // Contar números no texto.
        public static int TotalDeNumeros(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsNumber(text[i]))
                {
                    count++;
                }
            }
            return count;
        }
        // Contar espaços em branco.
        public static int TotalDeEspacos(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsWhiteSpace(text[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
