using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {

            double somanota = 0, media = 0, menornum = 424432, maiornum = -5464747;
          
            Console.WriteLine("Digite a quantidade de notas");
            int x = int.Parse(Console.ReadLine());
            double[] notas = new double[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Digite as notas");
                notas[i] = double.Parse(Console.ReadLine());
                somanota = notas[i] + somanota;
            }
            media = somanota / x;
            Console.WriteLine("média: " + media);
            for (int i = 0; i < x; i++)
            {
                if (notas[i] < menornum)
                {
                    menornum = notas[i];

                }
                if (notas[i] > maiornum)
                {
                    maiornum = notas[i];

                }

            }
            Console.WriteLine("menor número: " + menornum + " Maior número: " + maiornum);
            for (int i = 0; i < x; i++)
            {
                int contador = 0;
                int numerosabaixo = 0;
                int numerosnamedia = 0;
                int numerosacima = 0;
                while (contador < x)
                {
                    if (media > notas[contador])
                    {
                        numerosacima = numerosacima + 1;
                    }
                    if (media < notas[contador])
                    {
                        numerosabaixo = numerosabaixo + 1;

                    }
                    if (media == notas[contador])
                    {
                        numerosnamedia = numerosnamedia + 1;
                    }
                    contador++;
                }

                Console.WriteLine("Notas acima da média: " + numerosacima);
                Console.WriteLine("Notas abaixo da média: " + numerosabaixo);
                Console.WriteLine("Notas na média: " + numerosnamedia);
                double porcentacima;
                double porcentabaixo;
                double porcentnamedia;
               
                porcentacima = numerosacima * 100 / x;
                porcentabaixo = numerosabaixo * 100 / x;
                porcentnamedia = numerosnamedia * 100 / x;

                Console.WriteLine("Porcentagem acima da média: " + porcentacima + "%");
                Console.WriteLine("Porcentagem abaixo da média: " + porcentabaixo + "%");
                Console.WriteLine("Porcentagem na média: " + porcentnamedia + "%");
                Console.ReadLine();

            }
        }
    }
}

