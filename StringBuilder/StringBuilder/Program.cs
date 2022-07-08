using System;
using System.Text;

namespace StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria um texto de forma dinamica e não utiliza
            //muita memória
            var texto = new StringBuilder();
            texto.Append("Esse ");
            texto.Append("é ");
            texto.Append("um ");
            texto.Append("texto ");
            texto.Append("teste");

            Console.WriteLine(texto);
        }
    }
}
