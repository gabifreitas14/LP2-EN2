using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros;

            double mediabruta=0;
            double medianum;
            double medialiquida;
            double hue;



            Console.WriteLine("Digite quantos números deseja");
            numeros=int.Parse(Console.ReadLine());

            for (int i = 0; i < numeros; i++)
            {
                hue = i + 1;
                Console.WriteLine("Escreva o {0}° número", hue);
                medianum = double.Parse(Console.ReadLine());
                mediabruta = mediabruta + medianum;

                
            }

            medialiquida = (mediabruta / numeros);

            Console.WriteLine("A média dos {0} números é igual a {1}", numeros, medialiquida);

            Console.ReadKey();

        }
    }
}
