using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequenciafibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

           

            double [] fibonacci = new double [n+2];

            fibonacci[0] = 0;
            fibonacci[1]=1;
          

            for (int i = 1; i < n+1; i++)
            {
                fibonacci[i + 1] = fibonacci[i] + fibonacci[i - 1];

                Console.Write(fibonacci[i] + " ");

            }

            

        }
    }
}
