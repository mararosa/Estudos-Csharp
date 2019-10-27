using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exemplo:

            //Console.Write("Informe a quantidade de itens: ");
            //int qtdade = int.Parse(Console.ReadLine());
            //string[] array = new string[qtdade];

            //int i = 0;
            //while (i <= qtdade - 1)
            //{
            //    Console.Write("Informe um item: ");
            //    string item = Console.ReadLine();
            //    array[i] = item;
            //    i++;
            //}

            //Console.WriteLine("------------------------");

            //i = qtdade - 1;
            //while (i >= 0)
            //{
            //    Console.WriteLine(array[i]);
            //    i--;
            //}
            //Console.ReadLine();

            //// 1. Crie um array de inteiros de comprimento 10000 e preencha com os números de 1 a 10000 
            int[] inteirosAte10000 = new int[10000];

            for (int i = 0; i < 10000; i++)
            {
                inteirosAte10000[i] = i + 1;
                Console.WriteLine("Número: [" + i + "] = " + inteirosAte10000[i]);
            }

            Console.ReadLine();

            // 2. Crie um array de tamanho informado pelo usuário, preencha e imprima o conteúdo do array

            Console.Write("Informe a quantidade de itens da sua lista de compras: ");
            int qtdadeUsuario = int.Parse(Console.ReadLine());
            string[] tamanho = new string[qtdadeUsuario];


            for (int indice = 0; indice <= qtdadeUsuario - 1; indice++)
            {
                Console.Write("Informe o produto: ");
                string produto = Console.ReadLine();
                tamanho[indice] = produto;
            }

            Console.WriteLine("--------------------------------------------");

            for (int indice = 0; indice <= qtdadeUsuario - 1; indice++)
            {
                Console.WriteLine("Item: " + tamanho[indice]);
            }

            // Crie um array de tamanho informado pelo usuário, preencha e imprima o conteúdo do de trás pra frente
            Console.WriteLine("--------------------------------------------");

            for (int indice = qtdadeUsuario - 1; indice >= 0; indice--)
            {
                Console.WriteLine(tamanho[indice]);
            }

            Console.ReadLine();


            //// 3. Implemente um algoritmo que percorra uma string e imprima apenas os número
            ///
            Console.Write("Digite o que você quiser (letras e números): ");
            string texto = Console.ReadLine();

            for (int ind = 0; ind < texto.Length; ind++)
            {
                char caracterer = texto[ind];
                if (caracterer >= '0' && caracterer <= '9')
                {
                    Console.Write(caracterer);
                }
            }

            Console.WriteLine("FIM");
            Console.ReadLine();

            //// 4. Implemente um algoritmo que encontra o maior e o menor número de um array

            int[] arrayNum = new int[5];

            for (int index = 0; index < arrayNum.Length; index++)
            {
                Console.Write("Informe um número: ");
                int numero = int.Parse(Console.ReadLine());
                arrayNum[index] = numero;
            }

            int maior = arrayNum[0];
            int menor = arrayNum[0];

            for (int indice = 1; indice < arrayNum.Length; indice++)
            {

                if (arrayNum[indice] > maior)
                {
                    maior = arrayNum[indice];
                }
                if (arrayNum[indice] < menor)
                {
                    menor = arrayNum[indice];
                }
            }

            Console.WriteLine(maior + " é o maior");
            Console.WriteLine(menor + " é o menor");
            Console.ReadLine();

            //// 5. Implemente um algoritmo que ordena um array

            int[] arrayOrdem = new int[] { 3, 4, 2, 1 };

            int ordenar = 0;
            /*
            primeiro for = esse for fará com que  a variável i percorra o vetor a ser ordenado,
            mas ela vai andar uma casa enquanto a variável j percorre o vetor todo,
            ou seja i percorrerá apenas o tamanho do vetor ja j percorrerá o tamanho do
            vetor vezes o tamanho do vetor
            */
            for (int i = 0; i < arrayOrdem.Length; i++)
            {

                for (int j = 0; j < arrayOrdem.Length; j++)
                {


                    if (arrayOrdem[i] < arrayOrdem[j])
                    {
                        ordenar = arrayOrdem[i];
                        arrayOrdem[i] = arrayOrdem[j];
                        arrayOrdem[j] = ordenar;
                    }
                }
            }

            //esse for é simplesmente para testar a ordenação
            for (int k = 0; k < arrayOrdem.Length; k++)
            {
                Console.WriteLine(arrayOrdem[k]);
            }

            Console.ReadLine();


        }
    }
}
