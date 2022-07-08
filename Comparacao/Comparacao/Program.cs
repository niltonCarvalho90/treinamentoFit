using System;

namespace Comparacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testando";
            //Compara retornando um inteiro
            //Console.WriteLine(texto.CompareTo("Testando"));
            //StrigComparison.OrdinalIgnoreCase, ignora maiusc e minus na comparação
            Console.WriteLine(texto.Contains("testa", StringComparison.OrdinalIgnoreCase));
        }
    }
}
