using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc1_LP2_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números deseja calcular?");


            int qtd;
            qtd = int.Parse(Console.ReadLine());
            double[] num = new double[qtd];


            for (int i = 0; i < qtd; i++) // adiciona os números
            {
                Console.WriteLine("Escreva um dos números a serem calculados");
                num[i] = double.Parse(Console.ReadLine());

            }

            double soma = 0;
            for (int c = 0; c < qtd; c++) // lê os números
            {
                soma += num[c];

            }

            double media = soma / qtd;
            Console.WriteLine("A média é:" + media);



        }
    }
}
