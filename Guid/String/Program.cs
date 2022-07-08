using System;

namespace Guid
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("252d6ff5-7b0b-481c-bcd0-4231f67d9ae6");
            //Imprimir apenas os 8 primeiros digitos ramdomicos
            Console.WriteLine(id.ToString().Substring(0, 8));
        }
    }
}
