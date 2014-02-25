using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int calculo;
            Console.WriteLine("Quantos números deseja calcular?");
            calculo = int.Parse(Console.ReadLine());

            double[] numbers = new double[calculo];
            for (int i = 0; i < calculo; i++)
            {
                Console.WriteLine((i + 1) + "º número:");
                numbers[i] = double.Parse(Console.ReadLine());

            }

            double soma = 0;
            int z = 0;

            foreach (var num in numbers)
            {
                soma += numbers[z];
                z++;
            }

            double media = soma/calculo;
            Console.WriteLine("A média dos números digitados é {0}",  media);

            double menor = 0; 
            double maior = 0; 
            

            for (int i = 0; i < calculo; i++)
            {
                if (i == 0)
                 {
                      menor = numbers[i];
                      maior = numbers[i];
                   }

                    if (numbers[i] < menor)
                    {

                        menor = numbers[i];

                    }
                    else if (numbers[i] > maior)
                    {
                        maior = numbers[i];

                    }
                }
            Console.WriteLine("O menor número é:" + menor);

            Console.WriteLine("O maior número é:" + maior);

            }
    }
}

