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

            double[] g = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a nota coletada: ");
                g[i] = double.Parse(Console.ReadLine());
                soma += g[i];
            }

            // a) Média da avaliação do governo federal.
            Convert.ToDouble(n);
            media = soma / n;
            Console.WriteLine("A média de avaliação do Governo Federal é de " + media);

            // b) Menor nota dada...
            
        }
    }
}