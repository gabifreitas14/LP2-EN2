using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc1_LP2_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números deseja calcular?");


            int qtd;
            qtd = int.Parse(Console.ReadLine());
            double[] num = new double[qtd];


            for (int i = 0; i < qtd; i++) // adiciona os números
            {
                Console.WriteLine("Escreva um dos números a serem calculados");
                num[i] = double.Parse(Console.ReadLine());

            }

            double soma = 0;
            for (int c = 0; c < qtd; c++) // lê os números
            {
                soma += num[c];

            }

            double media = soma / qtd;
            Console.WriteLine("A média é:" + media);

            double numerodig = 0; // armazena os números do array num[i] (digitados pelo usuário)
            double maiornum = 0;
            double menornum = 0;

            for (int l = 0; l < qtd; l++) // Determina maior e menor número numa sequência
            {
                numerodig = num[l];
                if (numerodig < menornum || menornum == 0)
                {
                    menornum = numerodig;
                }

                if (numerodig > maiornum)
                {
                    maiornum = numerodig;
                }

            }
            Console.WriteLine("O menor número é: " + menornum); 
            Console.WriteLine("O maior número é: " + maiornum);

            double numacima = 0;
            double numabaixo = 0;
            for (int a = 0; a < qtd ; a++) //  Calcula a quantidade de números acima/abaixo da média
            {
                if (num[a] > media)
                {
                    numacima++; // acrescenta a quantidade 
                }
                if (num[a] < media)
                {
                    numabaixo++;
                }
            }
                
            Console.WriteLine("A quantidade de números acima da média são: " + numacima);
            Console.WriteLine("A quantidade de números abaixo da média são: " + numabaixo);

            double porcentacima = (numacima / qtd) * 100;
            double porcentabaixo = (numabaixo / qtd) * 100;
            Console.WriteLine("A porcentagem de números acima da média é: " + porcentacima + "%");
            Console.WriteLine("A porcentagem de números abaixo da média é: " + porcentabaixo + "%");
            
            if (media >= 4.87 && porcentacima >= 60)
            {
                Console.WriteLine("O candidato será reeleito!");
            }
            else 
            {
                Console.WriteLine("O candidato não será reeleito!");
            }

            double desvio = 0;
            for (int b = 0; b < qtd; b++)
            {
                if (num[b] >= media)
                {
                    desvio += num[b] - media; // += pq soma todos os valores
                }
                else
                {
                    desvio += media - num[b];
                }
            }

            desvio = desvio / qtd;
            Console.WriteLine("O desvio padrão é: " + desvio);

            double med = 0;
            for (int e = 0; e < qtd - 1; e++) // pega a qtd, como primeiro número para comparar
            {
                for (int p = e + 1; p < qtd; p++) // segundo número para comparar
                {
                    if (num[e] < num[p])
                    {
                        med = num[e]; // coloca os números em ordem crescente
                        num[e] = num[p];
                        num[p] = med;
                    }
                }
            }

            double mediana;
            if (qtd % 2 == 0)
            {
                int x = qtd / 2;
                int y = x - 1;
                mediana = (num[x] + num[y]) / 2;
            }
            else
            {
                int x = qtd / 2;
                mediana = num[x];
            }
               
            Console.WriteLine("A mediana é: " + mediana);
            Console.ReadKey();
        }
    }
}
