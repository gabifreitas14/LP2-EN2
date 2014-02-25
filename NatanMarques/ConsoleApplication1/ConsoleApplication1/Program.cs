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
            Console.WriteLine("Informe a quantidade de números:");
            int x = int.Parse(Console.ReadLine());
            double[] numbers = new double[x];

            // Colocar os números no array.
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Informe o {0}º número", i + 1);
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double mediafinal = 0;
            double media = 0;
                       

            //for (int j = 0; j < x; j++)
            //{
            //    numbers[j] = media;
            //    mediafinal += media;
            //}

            int y = -1;
            while(y < x)
            {
            numbers[y] = media;
            mediafinal += media;
            y++;       
            }
            Console.WriteLine("A média final é {0}", (mediafinal / x));

        }             
    }
}
