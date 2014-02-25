using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas pessoas iram avaliar o Governo Federal?");
            int qtd = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] pessoas = new int[qtd];
            double[] notas = new double[qtd];
            double soma = 0;
            double media = 10;
            double menornota = 10;
            double maiornota = 0;
            int qtdnotasabaixo = 0;
            int qtdnotasacima = 0;
            double porcenabaixo = 10;
            double porcenacima = 0;

            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine("Qual a sua nota para o Governo Federal?");
                notas[i] = double.Parse(Console.ReadLine());
                if (notas[i] > 10)
                {
                    Console.WriteLine("Não digite notas acima de 10!");

                    Console.WriteLine("Qual a sua nota para o Governo Federal?");
                    notas[i] = double.Parse(Console.ReadLine());
                }
                else if (notas[i] <= 0)
                {
                    Console.WriteLine("Você digitou uma nota menor que 0!");

                    Console.WriteLine("Qual a sua nota para o Governo Federal?");
                     notas[i] = double.Parse(Console.ReadLine());
                }

                Console.WriteLine();
                soma += notas[i];

                if (notas[i] < menornota)
                {
                    menornota = notas[i];
                }

                if (notas[i] > maiornota)
                {
                    maiornota = notas[i];
                }

            }

            media = soma / qtd;

            for (int i = 0; i < pessoas.Length; i++)
            {
                if (notas[i] < media)
                {
                    qtdnotasabaixo++;
                }
            }
            for (int i = 0; i < pessoas.Length; i++)
            {
                if (notas[i] > media)
                {
                    qtdnotasacima++;
                }

            }

            porcenabaixo = (100 * qtdnotasabaixo) / qtd;
            porcenacima = (100 * qtdnotasacima) / qtd;

            if (media >= 4.87 && porcenacima >= 60)
            {
                Console.WriteLine("O governo será reeleito!");
            }
            else
            {
                Console.WriteLine("O governo não será reeleito.");
                Console.WriteLine();
            }

                Console.WriteLine("A média das avaliações para o Governo Federal é {0}", Math.Round(media, 2));
                Console.WriteLine();

                Console.WriteLine("A menor nota dada foi {0}", menornota);
                Console.WriteLine();

                Console.WriteLine("A maior nota dada foi {0}", maiornota);
                Console.WriteLine();

                Console.WriteLine("A quantidade do notas abaixo da média é {0}", qtdnotasabaixo);
                Console.WriteLine();

                Console.WriteLine("A quantidade do notas acima da média é {0}", qtdnotasacima);
                Console.WriteLine();

                Console.WriteLine("A porcentagem de notas abaicxo média é {0}%", Math.Round(porcenabaixo,2));
                Console.WriteLine();
                Console.WriteLine("A porcentagem de notas acima da média é {0}%", Math.Round(porcenacima,2));
                Console.WriteLine();


                Console.ReadKey();
        }
    }
}
