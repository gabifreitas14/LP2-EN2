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
            int qntNumeros = 0;
            int contador = 1;
            double[] numeros;
            Console.WriteLine("Digite a quantidade de números que voce deseja usar");
            qntNumeros = int.Parse(Console.ReadLine());
            numeros = new double[qntNumeros];

            // Gravando os números digitados no array.
            for (int i = 0; i < qntNumeros; i++)
            {
                Console.Write("Digite o seu número: ");
                numeros[i] = double.Parse(Console.ReadLine());
            }

            // Lendo os números gravados
            double soma = numeros[0];
            foreach (var num in numeros)
            {
                if (contador > qntNumeros) { break; }
                else
                {
                    soma += numeros[contador - 1];
                    contador++;

                }
            }

            double media = soma / contador;
            Console.WriteLine("A sua média é: "+media);
            Console.ReadKey();
        }
    }
}
