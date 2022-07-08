using System;

namespace Indices
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Esse texto é um teste";
            //Conta a posição no indíce do caractere buscado
            Console.WriteLine(texto.IndexOf("é"));
            //Conta o último indice procurado no parametro
            Console.WriteLine(texto.LastIndexOf("s"));
        }
    }
}
