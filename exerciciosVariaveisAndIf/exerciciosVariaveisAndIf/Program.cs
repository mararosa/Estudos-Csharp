using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosVariaveisAndIf
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Leia um número e imprima se ele é positivo, negativo ou zero 

            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 > 0)
            {
                Console.WriteLine("Positivo");
            }
            else if (n1 == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
            Console.ReadLine();

            // 7. Leia um número e imprima se ele é ímpar, zero ou par

            Console.Write("Digite um número: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n2 == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (n2 % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Ímpar");
            }
            Console.ReadLine();

            //8. Leia três números e imprima o maior e o menor

            Console.Write("Digite o Primeiro Número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo Número: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Digite o Terceiro Número: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.Write("Primeiro número é o maior: " + a + " e o ");
            }
            else if (b > c)
            {
                Console.Write("Segundo número é o maior: " + b + " e o ");
            }
            else
            {
                Console.Write("Terceiro número é o maior: " + c + " e o ");
            }
            if (a < b && a < c)
            {
                Console.WriteLine("Primeiro número é o menor: " + a);
            }
            else if (b < c)
            {
                Console.WriteLine("Segundo número é o menor: " + b);
            }
            else
            {
                Console.WriteLine("Terceiro número é o menor: " + c);
            }
            Console.ReadLine();

            // 9.Leia um número, se < 10, criança, se < 18 adolescente, se não, adulto

            Console.WriteLine("Digite sua idade: ");
            int n4 = int.Parse(Console.ReadLine());

            if (n4 < 10)
            {
                Console.Write("Vocé é uma criança ;( ");
            }
            else if (n4 < 18)
            {
                Console.Write("Ainda é um adolescente o.O ");
            }
            else
            {
                Console.WriteLine(" Ops já é um adulto! ");
            }

            Console.ReadLine();

            // 10. Leia 4 notas de um aluno, calcule e imprima a média e imprima APROVADO para média superior ou igual a 7,0 ou REPROVADO para  inferior a 7,0.

            Console.Write("Digite a primeira nota: ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            int nota2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            int nota3 = int.Parse(Console.ReadLine());
            Console.Write("Digite a quarta nota: ");
            int nota4 = int.Parse(Console.ReadLine());
            int media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("Sua média é : " + media);

            if (media >= 7)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
            }
            Console.ReadLine();
        }
    }
}
