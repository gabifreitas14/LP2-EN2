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

            string materia = Console.ReadLine();

            string professor = Console.ReadLine();

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

            Console.WriteLine("Consolidação de Médias \r\nMatéria: {0} \r\nProfessor: {1}",materia,professor);



            for (int k = 0; k < qtdaluno; k++)
                {

                    if (media[k]>=6)
                    {
                        Console.WriteLine(string.Format("{0}: {{1:F1}}",nomealuno[k],media[k]));
                    }

                    

                    

                }
        }
    }
}
