using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            // //// Ex 1
            /////Leia um número da tela e imprima a tabuada de 0 a 10

            Console.Write("Digite um número: ");
            int usuario = int.Parse(Console.ReadLine());

            for (int tab = 0; tab <= 10; tab++)
            {
                Console.WriteLine(usuario + " X " + tab + " = " + (usuario * tab));
            }

            Console.ReadLine();

            // Ex 2
            // Peça um número maior que zero e imprima todos até zero

            int usuario2;

            do
            {
                Console.Write("Digite um número MAIOR que zero: ");
                usuario2 = int.Parse(Console.ReadLine());
            }
            while (usuario2 <= 0);


            for (; usuario2 >= 0; usuario2--)
            {

                Console.WriteLine(usuario2);
            }

            Console.ReadLine();

            // Ex 3
            // Peça uma quantidade e imprima um texto o tanto de vezes informado

            Console.Write("Informe a quantidade de vezes que o texto será apresentado: ");

            for (int usuario3 = int.Parse(Console.ReadLine()); usuario3 > 0; usuario3--)
            {

                Console.WriteLine("Girl Power!!! ");
            }


            Console.ReadLine();

            //// Ex 4
            // Peça um início e um fim, e impria todos os números no intervalo

            Console.Write("Informe um número para o Início: ");
            int inicio = int.Parse(Console.ReadLine());

            Console.Write("Informe outro número para o Fim: ");
            int fim = int.Parse(Console.ReadLine());


            for (int cursor = inicio; cursor <= fim; cursor++)
            {

                Console.WriteLine(cursor);
            }

            Console.ReadLine();

            //Ex 5
            //Peça para o usuário uma base e altura e imprima um retângulo de “#”


            Console.Write("Informe um número para a Altura: ");
            int altura = int.Parse(Console.ReadLine());

            Console.Write("Informe um número para a Base: ");
            int bas = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int cursorAltura = 0; cursorAltura < altura; cursorAltura++)
            {
                for (int cursorLargura = 0; cursorLargura < bas; cursorLargura++)
                {

                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
