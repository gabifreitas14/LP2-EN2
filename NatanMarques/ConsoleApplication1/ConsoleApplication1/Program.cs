﻿using System;
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
            Console.WriteLine("Informe a quantidade de números:");
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
            Console.WriteLine("A média final é {0}", media);

        }
    }
}
