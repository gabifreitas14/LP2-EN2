using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
             double soma = 0;

             string materia = Console.ReadLine();

             string professor = Console.ReadLine();
 
             int qtdaluno=int.Parse(Console.ReadLine());
 
             int qtdavaliacao=int.Parse(Console.ReadLine());
 
             double [,] alunonotas = new double[qtdaluno,qtdavaliacao];
 
             string [] nomealuno= new string[qtdaluno];

             double [] media = new double [qtdaluno];

             if (qtdaluno >= 2 && qtdaluno <= 1000 && qtdavaliacao >= 2 && qtdavaliacao <= 8)
             {


                 for (int i = 0; i < qtdaluno; i++)
                 {
                     nomealuno[i] = Console.ReadLine();



                     for (int a = 0; a < qtdavaliacao; a++)
                     {
                         alunonotas[i, a] = double.Parse(Console.ReadLine());

                         soma += alunonotas[i, a];

                     }

                     media[i] = soma / qtdavaliacao;

                     soma = 0;
                 }

                 Console.WriteLine("Consolidação de Médias \r\nMatéria: {0} \r\nProfessor: {1} \r\n",materia,professor);

                     

            
            for (int k = 0; k < qtdaluno; k++)

                 {

                     if (media[k]>=6)
                     {
                         Console.WriteLine(string.Format("{0,-20} : {1:F1} (Aprovado)", nomealuno[k], media[k]));
                     }

                     else if (media[k]<6 && media[k]>=5.5)
                     {
                         Console.WriteLine(string.Format("{0,-20} : {1:F1} (Pendente COC)", nomealuno[k], media[k]));
                     }

                     else
                     {
                         Console.WriteLine(string.Format("{0,-20} : {1:F1} (Reprovado)", nomealuno[k], media[k]));
                     }

                    

                     
 
                
             }

  
             }

            
             

            

            
        }
    }
}
