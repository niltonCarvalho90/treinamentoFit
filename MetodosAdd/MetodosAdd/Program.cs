using System;

namespace MetodosAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Esse texto é um teste";
            //Transforma todo o texto em minúsculo
            Console.WriteLine(texto.ToLower());
            //Transforma todo o texto em maiusculo
            Console.WriteLine(texto.ToUpper());
            //Insere o texto no indice na posição
            Console.WriteLine(texto.Insert(5, "Aqui "));
            //Remove o texto no indice na posição e a qntd
            Console.WriteLine(texto.Remove(5, 5));
            //Conta a qntd de caracteres de um String
            Console.WriteLine(texto.Length);

            {

            }
        }
    }
}
