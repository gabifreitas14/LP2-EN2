using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            double media = 0;
                        
            Console.WriteLine("Digite a quantidade de notas coletadas na pesquisa do IBGE: ");
            int n = int.Parse(Console.ReadLine());

            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a nota coletada: ");
                numbers[i] = double.Parse(Console.ReadLine());
                soma += numbers[i];
            }

            // Média da avaliação do governo federal
            media = soma / n;
            Console.WriteLine("A média de avaliação do Governo Federal é de " + media);
        
            // Quantidade de notas abaixo e acima da média
            int nota = 0;
            int nota2 =0;
            foreach (double number in numbers)
            {
                if (number < media)
                {
                    nota++;
                }
                else
                {
                    nota2++;
                }
            }
            Console.WriteLine("Houveram {0} notas abaixo da média", nota);
            Console.WriteLine("Houveram {0} notas acima da média", nota2);

            // Maior e menor notas

            // Porcentagem de pessoas acima e abaixo da média
                           
            

        }
    }
}