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

            IBGE pessoa = new IBGE();

            double a = 0;
            
            int y = 1;

            Console.WriteLine("Digite aqui a quantidade de números.");

            int num = int.Parse(Console.ReadLine());

            double[] array = new double[num+1];

            

               while (y < num+1 )
                {
                   Console.WriteLine("Digite os números" );

                array[y] = double.Parse(Console.ReadLine());

                if (array[y] > 10)
                {
                    Console.WriteLine("Você digitou um numero maior que 10");
                    y--;
                }

                a = array[y] + a;  

                    y++;

                } 
                
            
            Console.WriteLine("A media é {0:F2}",pessoa.media(a,num));

            Console.WriteLine("O maximo é " + pessoa.maximo(array,num));

            Console.WriteLine("O minimo é " + pessoa.minimo(array,num));

            Console.WriteLine("Tem " + pessoa.abaixodamedia(array,num) + " votaram abaixo da média");

            Console.WriteLine("Tem " + pessoa.acimadamedia(array,num) + " votaram acima da média");

            Console.WriteLine("Tem " + pessoa.namedia(array,num) + " pessoas na média");

            Console.WriteLine("{0:F1} % das pessoas votaram abaixo da média",pessoa.porcentabaixo(num));

            Console.WriteLine("{0:F1} % das pessoas votaram acima da média",pessoa.porcentacima(num));

            Console.WriteLine("O desvio padrão das notas: {0:F2} ",pessoa.desviop(array,num));

            Console.WriteLine(pessoa.status(a));
           
        }
    }
}
