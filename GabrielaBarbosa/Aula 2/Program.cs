using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula1;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
           IBGE pessoa = new IBGE();


           

             

             string materia = Console.ReadLine();

             string professor = Console.ReadLine();

             string email = Console.ReadLine();
 
             int qtdaluno=int.Parse(Console.ReadLine());
 
             int qtdavaliacao=int.Parse(Console.ReadLine());
 
             double [,] alunonotas = new double[qtdaluno,qtdavaliacao];
 
             string [] nomealuno= new string[qtdaluno];
            
              double []soma = new double[qtdaluno];

             if (qtdaluno >= 2 && qtdaluno <= 1000 && qtdavaliacao >= 2 && qtdavaliacao <= 8)
             {


                 for (int i = 0; i < qtdaluno; i++)
                 {
                     nomealuno[i] = Console.ReadLine();



                     for (int a = 0; a < qtdavaliacao; a++)
                     {
                         alunonotas[i, a] = double.Parse(Console.ReadLine());

                         soma [i]+= alunonotas[i, a];

                     }

                     
                 }

                 Console.WriteLine("Consolidação de Médias \r\nMatéria: {0} \r\nProfessor: {1} \r\n", materia, professor);

                 
                
            for (int k = 0; k < qtdaluno; k++)

                 {
                     Console.WriteLine(string.Format("{0,-20} : {1:F1} {2}", nomealuno[k], pessoa.media(soma[k], qtdavaliacao), pessoa.statu(pessoa.media(soma[k], qtdavaliacao))));
                    
    
             }

  
             }
    
        }

        

    }
}

