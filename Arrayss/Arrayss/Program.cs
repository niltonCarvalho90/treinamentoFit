using System;

namespace Arrayss
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();

            /*var meuArray = new int[5] {1, 2, 3, 4, 5 };
            meuArray[0] = 12;

            for (var index = 0; index < meuArray.Length; index++) {
                Console.WriteLine(meuArray[index]);
            }*/

            /*Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);
            Console.WriteLine(meuArray[4]);
            */
            
            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            meuArray[0] = 12;

            foreach (var item in meuArray) {
                Console.WriteLine(item);
            




            }
        }
    }
}
