using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int somap=0;

            int numero2;

            int somas = 0;

            int numero = int.Parse(Console.ReadLine());

            int [,] matriz = new int [numero,numero];

            for (int i = 0; i < numero; i++)
            {
                for (int k = 0; k < numero; k++)
                {
                    matriz[i, k] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < numero; i++)
            {
                somap+= matriz[i, i];

            }

            numero2 = numero-1;

            for (int i = 0; i < numero; i++)
            {
                somas += matriz[i, numero2];
                numero2--;
            }

            Console.WriteLine("Soma da diagonal principal: "+somap);
            Console.WriteLine("Soma da diagonal secundária: "+somas);
        }
    }
}
