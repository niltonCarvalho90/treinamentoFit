using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args) {

            var arr = new int[4];

            try
            {
                for (var index = 0; index < 10; index++)
                {
                    Console.WriteLine(arr[index]);
                }
            }
            //Tratamento de exceção específica de índice estourado
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o indice");

            }
            //Tratamento de exceção genérica
            catch (Exception ex)
            {
                Console.WriteLine("Algo de errado não está certo");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }

            finally {
                Console.WriteLine("Chegou ao fim");

            }
        }

        public class MinhaException : Exception {
          
            public DateTime QuandoAconteceu { get; set; }
        }
    }
}
