using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeGit
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0, result2 = 0, soma = 0, media;
            double notamax;
            int contador = 0;
            double notamin;

            Console.WriteLine("Digite a quantidade de notas");
            int qtd = int.Parse(Console.ReadLine());

            double[] notas = new double[qtd];

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Digite a nota");
                notas[i] = int.Parse(Console.ReadLine());
            }
     
            foreach (var nota in notas)
            {
                if(contador < qtd)
                {
                    soma += notas[contador];
                    contador++;
                }
            }

            media = soma / qtd;
            Console.WriteLine("A média é: " + media);

            
       
            Console.ReadKey();

        } 
    }
}
