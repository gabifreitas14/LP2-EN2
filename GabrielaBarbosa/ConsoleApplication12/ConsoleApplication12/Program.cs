using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cpf = new int[11];

            int[] um = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 0 };

            int[] dois = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] numeros = new int[10];

            int[] numerais = new int[10];

            int coraçao = 0;

            int coraçoes = 0;

            int i = 0;
            foreach (char digito in Console.ReadLine())
            {
                cpf[i++] = int.Parse(digito.ToString());

            }

            for (int f = 0; f < 11; f++)
            {
                Console.WriteLine(cpf[f]);
            }

            for (int a = 0; a < 10; a++)
            {
                numeros[a] = um[a] * cpf[a];

                numerais[a] = dois[a] * cpf[a];

                coraçao = coraçao + numeros[a];

                coraçoes = coraçoes + numerais[a];

            }


            int divisao = coraçao % 11;


            Console.WriteLine(divisao);

            int divisoes = coraçoes % 11;

            if (divisao == 0 || divisao == 1)
            {
                if (cpf[9] != 0)
                {
                    Console.WriteLine("CPF Inválido");

                }


            }


            else if ((11 - divisao) != cpf[9])
            {
                
                    Console.WriteLine("CPF Inválido");
            

            }

            else if (divisoes == 0 || divisoes == 1)
            {
                
                if (cpf[10] != 0)
                {
                    Console.WriteLine("CPF Inválido");

                }

                else
                {
                    Console.WriteLine("CPF Válido");
                }

            }

            else
            {
            
                if (11 - divisoes != cpf[10])
                {
                    Console.WriteLine("CPF Inválido");
                }

                else
                {
                    Console.WriteLine("CPF Válido");
                }


            }
        }
    }
}
