using System;

namespace Interpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 10.2;
            //Concatenando
            //var texto = "O preço do produto é " + price;
            //Usando o string.Format usando os índices
            //var texto = string.Format("O preço do produto é {0}", price);
            //Outra forma usando o $ e o @ não pula linha ou \n
            var texto = $@"O preço do 
            produto é {price}";

            Console.WriteLine(texto);
        }
    }
}
