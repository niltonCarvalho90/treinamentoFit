using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();

            decimal valor = 10.25m;
            //O C é o padrão da moeda no país e CultereInfo converte o tipo pro modelo do país
            // Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            //Arredonda automaticamente o número
            Console.WriteLine(Math.Round(valor));
            //Arredonda para cima o número(Telha)
            Console.WriteLine(Math.Ceiling(valor));
            //Arredonda para baixo o número(Chão)
            Console.WriteLine(Math.Floor(valor));
        }
    }
}
