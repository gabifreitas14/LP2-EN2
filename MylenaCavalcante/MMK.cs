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
            double y;


            double result2 = 0, result = 0, result3 = 0;

            Console.WriteLine("informe a quantidade de notas que notas digitadas");
            int x = int.Parse(Console.ReadLine());

            double[] notas = new double[x];

            for (int i = 0; i < x; i++)
            {

                Console.WriteLine("Digite uma das notas");

                notas[i] = double.Parse(Console.ReadLine());

                result = notas[i] + result;
            }

            result2 = result / x;

            Console.WriteLine(result2);


            Console.ReadKey();
        }
    }
}
