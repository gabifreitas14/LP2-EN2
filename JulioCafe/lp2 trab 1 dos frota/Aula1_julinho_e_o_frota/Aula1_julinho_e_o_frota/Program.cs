using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_julinho_e_o_frota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá amiguinho, digite a quantidade de números a serem usados para o calculo!");
            int qtd_num;
            int lidos_num = 0;
            qtd_num = int.Parse(Console.ReadLine());
            double[] conjunto = new double[qtd_num];
            Console.WriteLine(qtd_num + " numeros serão digitados, digite quais são !");
            while (lidos_num < qtd_num)
            {
                conjunto[lidos_num] = double.Parse(Console.ReadLine());
                if (lidos_num == qtd_num - 2)
                {
                    Console.WriteLine("digite o ultimo numero amiguinho!");
                }
                if (lidos_num < qtd_num -2)
                {
                    Console.WriteLine("Digite o proximo numero");
                }
                lidos_num++;

            }
            lidos_num = 0;
            Console.WriteLine("Esses foram os números armazenados");
            while (lidos_num < qtd_num)
            {
                Console.WriteLine(conjunto[lidos_num]);
                lidos_num++;
            }
            Console.ReadKey();
            Console.WriteLine("\r\n \r\n \r\n");
            Console.WriteLine("Amiguinho, agora é a hora de resultados! yeeeeaaaah!");
            Console.ReadKey();
            double maiornum = 0;
            double somadtodos = 0;
            double lendonum = 0;
            double menornum = 0;
            lidos_num = 0;
            while (lidos_num < qtd_num)
            {
                somadtodos = somadtodos + conjunto[lidos_num];
                lidos_num++;
            }
            double media = somadtodos / qtd_num;
            Console.WriteLine("Amiguinho, a média é: " + media);
            Console.ReadKey();
            lidos_num = 0;
            // Editei o While para corrigilo,
            //fiz uma viagem na aula julio, mas ontem brotou a resposta na minha mente
            //enquanto eu kgava !
            while (lidos_num < qtd_num)
            {
                lendonum = conjunto[lidos_num];
                if (maiornum < lendonum)
                {
                    maiornum = lendonum;
                }
                lidos_num++;
            }
            // dps que fiz o primeiro, só inverti as formulas ! ( e resetei variaveis ! )
            lidos_num = 0;
            // resetadas !
            Console.WriteLine("Amiguinho, o maior número é: " + maiornum);
            Console.ReadKey();
            menornum = conjunto[0];// primeiro da lista
                while (lidos_num < qtd_num) // poderia fazer no outro while, mas é mais facil de editar no futuro deste modo
                {
                    lendonum = conjunto[lidos_num];
                    if (menornum > lendonum )
                    {
                        menornum = lendonum;
                    }
                    lidos_num++;
                }
                Console.WriteLine("Amiguinho, o menor número é: " + menornum);
                Console.ReadKey();
            }
        }
    }