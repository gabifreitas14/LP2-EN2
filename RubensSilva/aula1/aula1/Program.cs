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
            double a = 0;
            
            double media;

            double maximo =0;
            double minimo = 0;

            int acimadamedia = 0;

            int abaixodamedia = 0;
             
            Console.WriteLine("Digite aqui a quantidade de números.");

            int num=int.Parse(Console.ReadLine());

            double[] array = new double[num];
            
            for (int i = 0; i < num; i++)
            {

            Console.WriteLine("Digite os números");

            array[i] = double.Parse(Console.ReadLine());

            if (maximo<array[i])
            {
                maximo = array[i];
            }
            if (minimo>array[i])
            {
                minimo = array[i];
            }

       

            a = array[i] + a;

            
            }
            
            media = a / num;
            
            for (int i = 0; i <num; i++)
            {
                if (media>array[i])
                {
                    acimadamedia++; 
                }

                else
                {
                    abaixodamedia++;
                }
            }
           
         

        

            Console.WriteLine("A media é " + media);

            Console.WriteLine("O maximo é " + maximo);

            Console.WriteLine("O minimo é " + minimo);

            Console.WriteLine("Tem "+abaixodamedia+"abaixo da média");

            Console.WriteLine("Tem " + acimadamedia + "abaixo da média");

        }
    }
}
