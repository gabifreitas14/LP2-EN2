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

            int qtdaluno=int.Parse(Console.ReadLine()); 
            
            double [] media = new double[qtdaluno];

            int qtdavaliacao=int.Parse(Console.ReadLine());

            int [,] alunonotas = new int[qtdaluno,qtdavaliacao];

            string [] nomealuno= new string[qtdaluno];

            for (int i = 0; i < qtdaluno; i++)
            {
                nomealuno[i] = Console.ReadLine();

                for (int a = 0; a < qtdavaliacao; a++)
                {
                    alunonotas[i, a] = int.Parse(Console.ReadLine());

                    soma+=alunonotas[i,a];

                }

                

                media[i]=soma/qtdavaliacao;
                
                soma=0; 
                
            }

            for (int k = 0; k < qtdaluno; k++)
                {
                    Console.WriteLine(nomealuno[k]+": "+media[k]);

                    

                }
        }
    }
}
