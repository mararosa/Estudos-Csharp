using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Percorra um array e imprima o valor de cada item utilizando foreach

            int[] numeros = new int[] { 3, 13, 7 };


            foreach (var n in numeros)
            {
                Console.WriteLine("Número: " + n);
            }

            Console.ReadLine();

            //2. Some o valor de todos os ítens de um array de int

            int[] arraySoma = new int[] { 3, 10, 8, 2, 6, 4 };
            int soma = 0;

            foreach (var num in arraySoma)
            {
                soma += num;
            }

            Console.WriteLine("Resultado = " + soma);
            Console.ReadLine();

            //3. Implemente um algoritmo que imprima um array de maneira agradável

            int[] numbers = new int[] { 17, 22, 33, 4, 89, 77, 548, 54 };


            Console.Write("[ ");

            foreach (var x in numbers)
            {

                Console.Write(x);
                Console.Write(", ");

            }
            Console.Write("]");
            Console.WriteLine();

            Console.ReadLine();

            // 4. Percorra um array e encontre todos os números repetidos, depois, monte um novo array com apenas um item de cada
            //Ex 4. Percorra um array e imprima todos os números pares e depois todos os números ímpares

            int[] arrayEx4 = new int[] { 17, 22, 33, 4, 89, 77, 548, 54 };

            Console.Write("Pares: [ ");
            foreach (var itemEx4 in arrayEx4)
            {
                if (itemEx4 % 2 == 0)
                {
                    Console.Write(itemEx4 + " ");
                }
            }

            Console.Write("]");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Impares: [ ");
            foreach (var itemEx4 in arrayEx4)
            {
                if (itemEx4 % 2 == 1)
                {
                    Console.Write(itemEx4 + " ");
                }
            }
            Console.Write("]");
            Console.ReadLine();
        }
    }
}
