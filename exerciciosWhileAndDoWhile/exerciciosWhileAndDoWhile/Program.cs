using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosWhileAndDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplos Apostila

            Console.Write("Informe um número: ");
            int n = int.Parse(Console.ReadLine());
            n = n - 1;
            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("Número " + n + " é par");
                }
                n--;
            }

            Console.ReadLine();

            int numero = 0;
            while (numero < 5)
            {
                Console.WriteLine(numero);
                numero++;
            }
            Console.ReadLine();

            // Exemplo 2

            while (true)
            {
                Console.WriteLine("Digite algo, caso queira sair, digite: EXIT ");

                string text = Console.ReadLine();
                if (text == "exit" || text == "EXIT")
                {
                    break;
                }
                Console.WriteLine(text);

            }
            Console.WriteLine("Fim");
            Console.ReadLine();

            //Exemplo 3

            int a = 10;
            int b = 0;

            while (a != b)
            {
                a--;
                b++;
            }
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);

            Console.ReadLine();


            // 11. Peça um número e imprima todos até zero
            Console.Write("Digite um número: ");
            int number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                Console.WriteLine(number);

                if (number > 0)
                {
                    number--;
                }
                else
                {
                    number++;
                }
            }

            Console.ReadLine();


            //12. Peça um número e imprima todos até zero pulando de dois em dois
            Console.Write("Digite um número: ");
            int numUser = int.Parse(Console.ReadLine());
            while (numUser != 0)
            {
                Console.WriteLine(numUser);

                if (numUser > 0)
                {
                    numUser -= 2;


                    if (numUser < 0)
                    {
                        numUser = 0;
                    }
                }
                else
                {
                    numUser += 2;

                    if (numUser < 0)
                    {
                        numUser = 0;
                    }
                }
            }

            Console.WriteLine(0);

            Console.ReadLine();

            //13. Peça um número menor que 100 e imprima todos até o 100
            int numMenorCem;

            do
            {
                Console.WriteLine("Informe um número MENOR que 100:");
                numMenorCem = int.Parse(Console.ReadLine());
            }
            while (numMenorCem >= 100);

            while (numMenorCem <= 100)
            {
                Console.WriteLine(numMenorCem);
                numMenorCem++;
            }

            Console.ReadLine();


            //14.Peça uma quantidade e imprima um texto o tanto de vezes informado
            int numEx14;
            string texto = "Girl Power!!!";

            do
            {
                Console.Write("Informe a quantidade de vezes (MAIOR QUE ZERO): ");
                numEx14 = int.Parse(Console.ReadLine());
            }
            while (numEx14 <= 0);

            while (numEx14 > 0)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(texto);

                numEx14--;
            }
            Console.ResetColor();
            Console.ReadLine();


            // 15. Leia um número da tela e imprima a tabuada de 0 a 1
            Console.Write("Informe um número: ");
            int usuario = int.Parse(Console.ReadLine());
            Console.WriteLine("Tabuada");
            int multiplicador = 0;
            while (multiplicador <= 10)
            {
                int resultado = usuario * multiplicador;
                Console.WriteLine(usuario + " X " + multiplicador + " = " + resultado);
                multiplicador++;
            }
            Console.ReadLine();

            // 16.Solicite usuário e senha até que a o usuário seja “aspnetmvc” e senha “aspnetmvc”
            Console.Write("Login: ");
            string login = Console.ReadLine();
            Console.Write("Senha: ");
            string password = Console.ReadLine();

            while (login != "hello" || password != "hello")
            {
                Console.WriteLine("Login e/ou Senha incorretos. Tente novamente ");
                Console.Write("Login: ");
                login = Console.ReadLine();
                Console.Write("Senha: ");
                password = Console.ReadLine();
            }
            Console.WriteLine("Login e Password corretos!");

            Console.ReadLine();

            // 17. Infinitamente, some os valores digitados pelo usuário e imprima na tela o valor acumulado
            int acumulado = 0;

            while (true)
            {
                Console.WriteLine("Número ");
                int numEx17 = int.Parse(Console.ReadLine());

                acumulado += numEx17;
                Console.WriteLine("Total-> " + acumulado);

                if (numEx17 == 7)
                {
                    Console.WriteLine("Saindo do loop...\n");
                    break;
                }

            }
            Console.WriteLine("FIM!");

            //18. Infinitamente, some os valores digitados e imprima o valor, a quantidade de amostras e a média
            float acc = 0;
            int qtde = 1;

            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Número: ");
                int numEx18 = int.Parse(Console.ReadLine());

                acc += numEx18;
                Console.WriteLine("Valor total: " + acc);
                Console.WriteLine("Quantidade digitada: " + qtde);
                qtde++;
                float media = acc / qtde;
                Console.WriteLine("Média: " + media);

            }
        }
    }
}
