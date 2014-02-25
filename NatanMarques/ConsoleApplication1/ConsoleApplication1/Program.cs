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

            // Colocar os números no array.
            double soma = 0;
            double media = 0;

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Informe o número:");
                numbers[i] = double.Parse(Console.ReadLine());
                soma += numbers[i];                                 
            }
            
            media = (soma / x);
            

            Console.WriteLine("A média final é {0:0.00}", media);

            double maior = 0;
            double menor = 0;
            int w = 0;
            if (w == 0)
            {
                maior = numbers[0];
                menor = numbers[0];
            }
            if (numbers[w] < menor)
            {
                menor = numbers[w];
            }
            else if (numbers[w] > maior)
            {
                maior = numbers[w];
                
            }
            Console.WriteLine("Maior nota digitada = " + maior);
            Console.WriteLine("Menor nota digitada= " + menor);

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


        }
    }
}
