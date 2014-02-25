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

            Console.WriteLine();

            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a nota coletada: ");
                numbers[i] = double.Parse(Console.ReadLine());
                soma += numbers[i];
            }

            Console.WriteLine();

            // Média da avaliação do governo federal
            media = soma / n;
            Console.WriteLine("A média de avaliação do Governo Federal é de {0:0.00}", media);

            Console.WriteLine();

            // Quantidade de notas abaixo e acima da média
            int qnt = 0;
            int qnt2 = 0;
            foreach (double number in numbers)
            {
                if (number < media)
                {
                    qnt++;
                }
                else
                {
                    qnt2++;
                }
            }
            Console.WriteLine("Houveram {0} notas abaixo da média", qnt);
            Console.WriteLine("Houveram {0} notas acima da média", qnt2);

            Console.WriteLine();

            // Porcentagem de pessoas acima e abaixo da média
            double porc1;
            double porc2;
            
                porc1 = ((double)qnt / n) * 100;
                porc2 = ((double)qnt2 / n) * 100;
            
            Console.WriteLine("A porcentagem de pessoas abaixo da média é de {0:0.00}%", porc1);
            Console.WriteLine("A porcentagem de pessoas acima da média é de {0:0.00}%", porc2);
            

        }
    }
}