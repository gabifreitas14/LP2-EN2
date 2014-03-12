using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            double a = 0;
            double porcent;
            double media;
            double porcent2;
            double maximo = 0;
            double minimo = 0;
            double soma = 0;
            double variancia = 0;
            int h = 0;
            int acimadamedia = 0;
            int namedia = 0;
            int abaixodamedia = 0;

            

            Console.WriteLine("Digite aqui a quantidade de números.");


            int num = int.Parse(Console.ReadLine());
            double[] desvio = new double[num+1];
            double[] array = new double[num+1];
            double[] quadrado = new double[num+1];


          
               int y = 1;

               while (y < num+1 )
                {
                   Console.WriteLine("Digite os números" + h++);

                array[y] = double.Parse(Console.ReadLine());

                if (array[y] > 10)
                {
                    Console.WriteLine("Você digitou um numero maior que 10");
                    y--;
                }

                a = array[y] + a;  

                    y++;

                } 
                
               

               

            

            minimo = array[1];

            maximo = array[1];

            media = a / num;

          



            for (int i = 1; i < num+1; i++)
            {
               
                if (maximo < array[i])
                {
                    maximo = array[i];
                }
                if (minimo > array[i])
                {
                    minimo = array[i];
                }
                if (media > array[i])
                {
                    abaixodamedia++;
                }
                if (media < array[i])
                {
                    acimadamedia++;
                }
                if(media == array[i])
                {
                    namedia++;
                }

                desvio[i] = (array[i] - media);

                quadrado[i]= desvio[i] * desvio[i];
                
                soma = quadrado[i] + soma;

                


            }
            variancia =  Math.Sqrt (soma / media);

            porcent = (100 * abaixodamedia) / num;

            porcent2 = (100 * acimadamedia) / num;

            Console.WriteLine("A media é {0:F2}",media);

            Console.WriteLine("O maximo é " + maximo);

            Console.WriteLine("O minimo é " + minimo);

            Console.WriteLine("Tem " + abaixodamedia + " votaram abaixo da média");

            Console.WriteLine("Tem " + acimadamedia + " votaram acima da média");

            Console.WriteLine("Tem " + namedia + " pessoas na média");

            Console.WriteLine("{0:F1} % das pessoas votaram abaixo da média",porcent);

            Console.WriteLine("{0:F1} % das pessoas votaram acima da média",porcent2);

            Console.WriteLine("O desvio padrão das notas: {0:F2} ",variancia);

            if (a >= 4.87 && porcent2 > 60)
            {
                Console.WriteLine("O governante vai ser reeleito");

            }

            else
            {
                Console.WriteLine("O governante não será reeleito");
            }
        }
    }
}
