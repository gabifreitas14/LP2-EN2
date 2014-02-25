using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_IBGE
{
    class Program
    {
        static void Main(string[] args)
        {
            int npessoas=0;
            int baixomedia=0;
            int altamedia=0;

            double porcentmin = 0;
            double porcentmax = 0;
            double media = 0;
            double maxima = 0;
            double minima = 0;
            
            Console.WriteLine("Digite quantas notas foram coletadas na pesquisa (De 0 a 100000)");
            npessoas = int.Parse(Console.ReadLine());
           
            double[] notas = new double[npessoas];

            for (int i = 0; i < npessoas; i++)
            {
                    Console.WriteLine("Digite a {0}° nota (De 0 a 10)", i+1);
                    notas[i] = double.Parse(Console.ReadLine());
                    media = notas[i] + media;         
            }


            double mediareal = media / npessoas;

            minima = notas[0];
            maxima = notas[0];


            //Notas mínima e máxima
            for (int i = 0; i < npessoas; i++)
            {
                if (notas[i] > maxima )
                {
                    maxima = notas[i];

                }

                if (notas[i] < minima )
                {
                    minima = notas[i];
                }
            }


            //Notas acima e abaixo da média
            for (int i = 0; i < npessoas; i++)
            {
                if(notas[i] < mediareal)
                {
                    baixomedia = baixomedia+1;
                }

                if(notas[i] > mediareal)
                {
                    altamedia = altamedia+1;
                }
            }


            //Porcentagem de notas abaixo e acima da média
            porcentmin = (100 * baixomedia) / npessoas;
            porcentmax = (100 * altamedia) / npessoas;



            //Previsão do IBGE
            if (mediareal > 4.87 && porcentmax > 60)
            {
                Console.WriteLine();
                Console.WriteLine("A estimativa do IBGE é que seja reeleito");
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("A estimativa do IBGE é que não seja reeleito");
            }


            //Escrevendo no console
            Console.WriteLine();
            Console.WriteLine("A média de {0} pessoas é igual a {1}", npessoas, mediareal);
            Console.WriteLine();
            Console.WriteLine("O menor valor atribuído a uma nota foi: {0}", minima);
            Console.WriteLine();
            Console.WriteLine("O maior valor atribuído a uma nota foi: {0}", maxima);
            Console.WriteLine();
            Console.WriteLine("A quantidade de notas abaixo da média foi igual a: {0}", baixomedia);
            Console.WriteLine();
            Console.WriteLine("A quatidade de notas acima da média foi igual a: {0}", altamedia);
            Console.WriteLine();
            Console.WriteLine("A pocentagem de notas abaixo da média foi igual a: {0}%", porcentmin);
            Console.WriteLine();
            Console.WriteLine("A porcentagem de notas acima da média foi igual a: {0}%", porcentmax);

            Console.ReadKey();
        }
    }
}
