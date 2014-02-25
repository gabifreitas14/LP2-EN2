using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Quantidade dos números.
            Console.WriteLine("Informe a quantidade de notas: ");
            int x = int.Parse(Console.ReadLine());
            double[] numbers = new double[x];
            Console.WriteLine(" ");

            // Colocar os números no array.
            double soma = 0;
            double media = 0;

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Informe o número:");
                numbers[i] = double.Parse(Console.ReadLine());
                soma += numbers[i];
            }
            Console.WriteLine(" ");

            media = (soma / x);


            Console.WriteLine("A média final é {0:0.00}", media);

            double maior = 0;
            double menor = numbers[0];
            Console.WriteLine(" ");

            // Para cada numero
            // Se o numero e menor do que o menor até agora
            // O menor numero atual será o novo numero encontrado

            for (int i = 1; i < x; i++)
            {
                if (numbers[i] < menor)
                {
                    menor = numbers[i];
                }

            }

            Console.WriteLine("Menor nota digitada= " + menor);
            Console.WriteLine(" ");
            for (int i = 0; i < x; i++)
            {
                if (numbers[i] > maior)
                {
                    maior = numbers[i];
                }

            }            
            
            Console.WriteLine("Menor nota digitada= " + maior);
            Console.WriteLine(" ");
            // Maior e menor nota
            foreach (double number2 in numbers)
            {


            }
            // QTD Notas abaixo da média;
            int j = 0;
            int k = 0;
            foreach (double number in numbers)
            {
                if (number < media)
                {
                    j++;

                }
                else
                {
                    k++;
                }


            }
            Console.WriteLine("Foram {0} notas abaixo da média", j);
            Console.WriteLine("Foram {0} notas acima da média", k);
            Console.WriteLine(" ");
            // Porcentagem de notas maiores e porcentagem
            double porcent1 = 0;
            double porcent2 = 0;
            double som1 = j + k;

            porcent1 = ((double) j / x) * 100;
            porcent2 = ((double) k / x) * 100;

            Console.WriteLine("A porcentagem de notas abaixo da média foi {0:0.00}%", porcent1);
            Console.WriteLine("A porcentagem de notas acima da média foi {0:0.00}%", porcent2);



            Console.WriteLine(" ");


            
        }
    }
}


