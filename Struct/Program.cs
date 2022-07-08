using System;

namespace struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(1, "Mouse Gamer", 99.99);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Nome);
            Console.WriteLine(mouse.Preco);
        }
        struct Product{

            public Product(int id, string nome, double preco){
               
                Id = id;
                Nome = nome;
                Preco = preco;

            }


            public int Id;
            public string Nome;
            public double Preco;

            public double PrecoEmDolar(double dolar){

                return Preco * dolar;

            }

        }
    }
}
