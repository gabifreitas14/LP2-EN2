using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir quantos números ele quer
            int calculo;
            Console.Write("Quantos números deseja calcular? ");
            calculo = int.Parse(Console.ReadLine());

            // Escrever os números que ele quer
            double[] numbers = new double[calculo];
            for (int i = 0; i < calculo; i++)
            {
                Console.Write((i + 1) + "º número: ");
                numbers[i] = double.Parse(Console.ReadLine());

            }

            // Descobrir a média dos números
            double soma = 0;
            int z = 0;

            foreach (var num in numbers)
            {
                soma += numbers[z];
                z++;
            }

            double media = soma / calculo;
            Console.WriteLine("A média dos números digitados é {0}", media);

            // Descobrir o mínimo e o máximo valor
            double menor = 0;
            double maior = 0;


            for (int i = 0; i < calculo; i++)
            {
                if (i == 0)
                {
                    menor = numbers[i];
                    maior = numbers[i];
                }


                if (numbers[i] < menor)
                {

                    menor = numbers[i];

                }
                else if (numbers[i] > maior)
                {
                    maior = numbers[i];

                }
            }
            Console.WriteLine("O menor número é: " + menor);

            Console.WriteLine("O maior número é: " + maior);
            
            // Descobrir quantos números são maiores ou menores que a média

            int contador = 0;
            int contadormenor = 0;
            double porcento = 0;
            double porcentomenor = 0;

            for (int i = 0; i < calculo; i++)
            {
                if (numbers[i] >= media) {
                    Console.WriteLine("Este número é acima da média: " + numbers[i]);
                    contador++;
                    }
                else if (numbers[i] <= media)
                {
                    Console.WriteLine("Este número é abaixo da média: " + numbers[i]);
                    contadormenor++;
                }
 }
            Console.WriteLine(" ");
            Console.WriteLine("Existem {0} números maiores que a média.", contador);
            Console.WriteLine("Existem {0} números menores que a média", contadormenor);
            porcento = (contador * 100) / calculo;
            porcentomenor = (contadormenor * 100) / calculo;

            Console.WriteLine("A porcentagem de números maiores que a média é: {0}%", porcento);
            Console.WriteLine("A porcentagem de números menores que a média é: {0}%", porcentomenor);


            
            
        }
    }
}


