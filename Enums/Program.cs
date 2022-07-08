using System;

namespace Enums
{
      class Program
    {
        static void Main(string[] args)
        {
          var mouse = new Product(1, "Mouse gamer", 99.99, EProductType.Product);
          var manutencaoEletrica = new Product(2, "Manutenção Elétrica", 50.00, EProductType.Service);

            Console.writeLine(mouse.Id);
            Console.writeLine(mouse.Nome);
            Console.writeLine(mouse.Preco);
            Console.writeLine(mouse.Product);
        }

      
        public int Id;
        public string Nome;
        public double Preco;
        public EProductType Type;

        
    }

        struct Product(int id, string nome, double preco, EProductType type){

            Id = id;
            Nome = nome;
            Preco = preco;
            Type = type

        }

        enum EProductType{
            Product = 1,
            Service = 2

        }
}
