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
            double nmin = 10;
            double nmax = 0;
            int aumenta = 0;

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
                    soma += numeros[aumenta];
                    aumenta++;                   
                   
                }
                
            }
            media = soma / qtd;
            Console.WriteLine("A media é: " + media);
            
           for (int i = 0; i < qtd; i++)
            {
                if (numeros[i] > nmax) 
                {
                    nmax = numeros[i];
                    
                }
                if (numeros[i] < nmin)
                {
                    nmin = numeros[i];
                     
                }
                else if (nmax == nmin)
                {                   
                    Console.WriteLine("Existem números iguais.");
                }
            }
           Console.WriteLine("O maior número é: " + nmax);
           Console.WriteLine("O menor número é: " + nmin);
           Console.ReadKey();
        }
    }
}
