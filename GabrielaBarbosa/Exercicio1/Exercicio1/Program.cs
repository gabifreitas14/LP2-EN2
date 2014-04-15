using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int nquadrado = n * n;


            for (int i = 2; i <= nquadrado; i+=2)
            {
                Console.Write(" "+i);
            }
            Console.WriteLine();
            for (int i = 1; i <nquadrado; i+=2)
            {
                Console.Write(" "+i);
            }

        }
    }
}
