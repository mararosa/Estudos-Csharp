using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Leia um texto e imprima “O texto informado foi _”

            Console.Write("Digite algo: ");
            string etapa1 = Console.ReadLine();
            Console.WriteLine("O texto informado foi: " + etapa1);

            Console.ReadLine();

            //2. Leia um número e imprima o dobro e o triplo

            Console.Write("Digite um número: ");
            int etapa2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O número digitado foi: " + etapa2);
            int dobro = etapa2 * 2;
            int triplo = etapa2 * 3;
            Console.WriteLine("Dobro: " + dobro);
            Console.WriteLine(" Triplo: " + triplo);

            Console.ReadLine();

            // 3. Leia um número e imprima o número, o anterior e o próximo

            Console.Write("Digite um número: ");
            int etapa3 = int.Parse(Console.ReadLine());
            int anterior = etapa3 - 1;
            int posterior = etapa3 + 1;

            Console.WriteLine("Número Anterior: " + anterior);
            Console.WriteLine("Número Posterior: " + posterior);

            Console.ReadLine();

            // 4. Leia três números, some e imprima o resultado

            Console.Write("Digite o primeiro número: ");
            string etapa4 = Console.ReadLine();
            int n1 = int.Parse(etapa4);
            Console.Write("Digite o segundo número: ");
            etapa4 = Console.ReadLine();
            int n2 = int.Parse(etapa4);
            Console.Write("Digite o terceiro número: ");
            etapa4 = Console.ReadLine();
            int n3 = int.Parse(etapa4);
            int soma = n1 + n2 + n3;
            Console.WriteLine("A soma dos valores é: " + soma);

            Console.ReadLine();

            // 5. Leia três números e os imprima do último para o primeiro

            Console.Write("Digite o primeiro número: ");
            string etapa5 = Console.ReadLine();
            int num1 = int.Parse(etapa5);
            Console.Write("Digite o segundo número: ");
            etapa5 = Console.ReadLine();
            int num2 = int.Parse(etapa5);
            Console.Write("Digite o terceiro número: ");
            etapa5 = Console.ReadLine();
            int num3 = int.Parse(etapa5);

            Console.WriteLine("O Terceiro número é: " + num3);
            Console.WriteLine("O Segundo número é: " + num2);
            Console.WriteLine("O Primeiro número é: " + num1);

            Console.ReadLine();
        }
    }
}
