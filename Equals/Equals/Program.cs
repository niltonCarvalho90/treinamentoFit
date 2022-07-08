using System;

namespace Equals
{
    class Programs
    {
        static void Main(string[] args)
        {
            var texto = "Esse texto é um teste";
            //O texto é igual
            Console.WriteLine(texto.Equals("Esse"));
            Console.WriteLine(texto.Equals("Esse texto é um teste"));
        }
    }
}
