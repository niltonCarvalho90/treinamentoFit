using System;

namespace StartsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Esse é um texto teste";
            //O texto começa com, retorna um boolean
            Console.WriteLine(texto.StartsWith("Esse"));
            Console.WriteLine(texto.StartsWith("esse", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.StartsWith("texto"));

            //O texto termina com, retorna um boolean
            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
        }
    }
}
