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
            bool b = true;
            double a = 0;
            double porcent;
            double media;
            double porcent2;
            double maximo = 0;
            double minimo = 0;
            int h = 0;
            int acimadamedia = 0;
            int namedia = 0;
            int abaixodamedia = 0;
            

            Console.WriteLine("Digite aqui a quantidade de números.");
            

            int num = int.Parse(Console.ReadLine());

            double[] array = new double[num];
           
            


                for (int i = 0; i < num; i++)
                {

                    Console.WriteLine("Digite os números" + h++);
    
                        array[i] = double.Parse(Console.ReadLine());

                   if (array[i] > 10)
                    {
                        Console.WriteLine("Você digitou um numero maior que 10");     
                    }

                    a = array[i] + a;

                }

                minimo = array[0];

                maximo = array[0];

                media = a / num;

                for (int i = 0; i < num; i++)
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
                    if (media<array[i])
                    {
                        acimadamedia++;
                    }
                    else
                    {
                       namedia++;
                    }
                }
                 
                porcent = (100 * abaixodamedia) / num;

                porcent2 = (100 * acimadamedia) / num;
                
                Console.WriteLine("A media é " + media);

                Console.WriteLine("O maximo é " + maximo);

                Console.WriteLine("O minimo é " + minimo);

                Console.WriteLine("Tem " + abaixodamedia + " votaram abaixo da média");

                Console.WriteLine("Tem " + acimadamedia + " votaram acima da média");
                
                Console.WriteLine("Tem " + namedia + " pessoas na média");
               
                Console.WriteLine("Tem " + porcent + "% de pessoas votaram abaixo da média");

                Console.WriteLine("Tem " + porcent2 + "% de pessoas votaram acima da média");

                 if (a>=4.87 && porcent2 >60)
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
