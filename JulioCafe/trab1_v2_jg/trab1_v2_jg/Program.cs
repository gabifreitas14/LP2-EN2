using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab1_v2_jg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá amiguinho, digite a quantidade de pessoa(s) que votaram");
            int qtd_num;
            int lidos_num = 0;
            qtd_num = int.Parse(Console.ReadLine());
            double[] conjunto_ord = new double[qtd_num];
            double[] conjunto = new double[qtd_num];
            Console.WriteLine(qtd_num + " notas serão digitadas !!!, informe quais são !");
            while (lidos_num < qtd_num)
            {
                conjunto[lidos_num] = double.Parse(Console.ReadLine());
                if (lidos_num == qtd_num - 2)
                {
                    Console.WriteLine("digite a ultima nota amiguinho!");
                }
                if (lidos_num < qtd_num -2)
                {
                    Console.WriteLine("Digite a proxima nota amiguinho!");
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
                lidos_num = 0;
                int contadormenores = 0;
                int contadormaior = 0;
                while (lidos_num < qtd_num)
                {
                    if (conjunto[lidos_num] < media)
                    {
                        contadormenores = contadormenores + 1;
                    }
                    if (conjunto[lidos_num] > media)
                    {
                        contadormaior = contadormaior + 1;
                    }
                    lidos_num++;
                }
                Console.WriteLine("Amiguinho, foram encontrados "+contadormaior+" numeros maiores   que a media e "+contadormenores+" numeros menores que a media!");
                Console.ReadLine();
                double porcentmaior =(contadormaior * 100) / qtd_num;
                double porcentmenor = (contadormenores * 100) / qtd_num;
                Console.WriteLine(porcentmaior+"% dos numeros dados estão acima da média e "+porcentmenor+"% estão abaixo da média,               amiguinho!");
                Console.ReadKey();
                if (porcentmaior >= 60 && media > 4.87)
                {
                    Console.WriteLine("segundo o IBGE vocÊ será reeleito por conta de ter mais de 60% de aprovação...  EBA!");
                }
                else
                {
                    Console.WriteLine("Que pena! Segundo o IBGE não vai ter mensalão esse ano! Pois suas notas foram   abaixo de 60% da média... :'(");
                }
                Console.WriteLine("Então amiguinho, gostaria de calcular o desvio padrão das notas?(sim/não)");
                string respostaescrota = Console.ReadLine();
                if (respostaescrota == "sim")
                {
                    // STARTEI A CONTA RIDICULA DO DESVIO PADRÃO
                    double resultado = 0;
                    double quadradodeoito = 0;
                    double somadesvios = 0;
                    double sd = 0;
                    int contador = 0;
                    while (contador < qtd_num)
                    {
                        sd = (conjunto[contador] - media);
                        quadradodeoito = sd * sd;
                        somadesvios += quadradodeoito;
                        contador++;
                    }
                    double dp = somadesvios / qtd_num;
                    resultado = Math.Sqrt(dp); 
                    Console.WriteLine("O desvio padrão é "+resultado);
                }
                else
                {
                    Console.WriteLine("Ok... Estou me sentindo rejeitado... :'(");
                }
                Console.ReadLine();


                // MEDIANA
                    // FINAL DO CODIGO !
                    Console.WriteLine("Amiguinho, agora aperte a tecla enter para me assassinar brutalmente! yeeeaaahh! não se preocupe, será uma morte rapida! :D");
                Console.ReadLine();
                Console.WriteLine("Não acredito que você fez isso! achei que fosse meu amiguinho! /r/n nãããããão!!!!! D:<");
                Console.ReadKey();
            }
        }
    }
