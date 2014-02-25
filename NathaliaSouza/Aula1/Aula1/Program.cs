using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            double media;
            double min;
            double max;
            int aumenta = 1;

            Console.WriteLine("Quantos números deseja inserir?");
            int qtd = int.Parse(Console.ReadLine());
            double[] numeros = new double[qtd];
            
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Coloque os números: ");
                numeros[i] = int.Parse(Console.ReadLine());

                if (aumenta > qtd)
                {
                    break;
                }
                else
                {
                    soma += numeros[aumenta - 1];
                    aumenta++;                   
                   
                }
                
            }
            media = soma / qtd;
            Console.WriteLine("A media é: " + media);
            Console.ReadKey();

        }
    }
}
