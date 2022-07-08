using System;

namespace ManipulandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = " Esse texto é um teste ";
            //Serve para troca uma string por outra
            Console.WriteLine(texto.Replace("Esse", "Isso"));
            //Serve para quebrar uma lista em várias, dividindo
            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            Console.WriteLine(divisao[4]);
            //Serve para pegar uma string do texto apartir de
            //uma posição e com a qntd de caracteres
            var resultado = texto.Substring(5, 5);
            Console.WriteLine(resultado);

            //Retira o espaço do começo e do final da String
            Console.WriteLine(texto.Trim());
        }
    }
}
