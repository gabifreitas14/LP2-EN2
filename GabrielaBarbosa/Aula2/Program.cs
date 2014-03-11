using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;

            double media = 0;

            int qtdaluno=int.Parse(Console.ReadLine());

            int qtdavaliacao=int.Parse(Console.ReadLine());

            int [,] alunonotas = new int[qtdaluno,qtdavaliacao];

            string [] nomealuno= new string[qtdaluno];

            for (int i = 0; i < qtdaluno; i++)
            {
                nomealuno[i] = Console.ReadLine();

                for (int a = 0; a <= qtdavaliacao; a++)
                {
                    alunonotas[i, a] = int.Parse(Console.ReadLine());

                   
                }

                for (int k = 0; k <= qtdaluno; k++)
                {
                    Console.WriteLine(nomealuno[k]);

                    for (int j = 0; j < qt; j++)
                    {
                        
                    }

                }
                
            }

        }
    }
}
