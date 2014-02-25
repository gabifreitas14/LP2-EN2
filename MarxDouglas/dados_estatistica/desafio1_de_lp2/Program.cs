using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1_de_lp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Quantidade_de_notas, contador,i = 0, Notas_acima_da_media,  Notas_abaixo_da_media, x = 1;
            double[] Notas;
            double soma, media, Maior_nota = 0, Menor_nota = 10, PorCento_abaixo_da_media = 0, PorCento_acima_da_media = 0;

            Console.Write("Quantidade de notas adquiridas:");
            Quantidade_de_notas = int.Parse(Console.ReadLine());

            if (!(Quantidade_de_notas > 1 && Quantidade_de_notas < 100000))
            {                
                Console.WriteLine("A Quantidade de notas está incorreta");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            
            //Gravando as notas digitadas no array 

            Notas = new double[Quantidade_de_notas];            
            while(i < Quantidade_de_notas)
            {
                Console.Write("Digite as notas obtidas:");                
                Notas[i] = Math.Round(double.Parse(Console.ReadLine()), 2);

                if (Maior_nota < Notas[i]) {Maior_nota = Notas[i];}                
                if (Menor_nota > Notas[i]) {Menor_nota = Notas[i];}   
                i++;
            }
            //Fazendo a soma das notas para a média

            soma = 0;
            contador = 1;           
            foreach(var nota in Notas)
            {

                if (contador > Quantidade_de_notas)
                {
                    break;
                }
                else
                {
                    soma += Notas[contador - 1];
                    contador++;
                }
            }

            media = soma / Quantidade_de_notas;
            Console.WriteLine("A media de todas as notas obtidas é:" + media);

            //Encontrando menor e maior nota

            Console.WriteLine("A menor nota obtida:" + Menor_nota);
            Console.WriteLine("A maior nota obtida:" + Maior_nota);

            //Encontrando a quantidade de notas abaixo da média e a porcentagem de notas abaixo da média

            i = 0;
            if (i < Quantidade_de_notas)
            {                
                Notas_abaixo_da_media = 0;
                while (media > Notas[i])
                {
                    Notas_abaixo_da_media += 1;
                    i++;
                }
                Console.WriteLine("A quantidade de notas abaixo da média é:" + Notas_abaixo_da_media);                             
                PorCento_abaixo_da_media = ((Notas_abaixo_da_media * 100) / (Quantidade_de_notas * x));
                Console.WriteLine("A porcentagem de notas abaixo da média é:" + PorCento_abaixo_da_media + "%");               
            }

            //Encontrando a quantidade de notas acima da média e a porcentagem de notas acima da média
            i = 0;
            if (i < Quantidade_de_notas)
            {
                Notas_acima_da_media = 0;
                while (media > Notas[i])
                {
                    Notas_acima_da_media += 1;
                    i++;
                }             
                Console.WriteLine("A quantidade notas acima da média é:" + Notas_acima_da_media);
                PorCento_acima_da_media = ((Notas_acima_da_media * 100) / (Quantidade_de_notas * x));
                Console.WriteLine("A porcentagem de notas acima da média é:" + PorCento_acima_da_media + "%");
            }
                       
            //Previsão de reeleição
            if (media > 4.87 && PorCento_acima_da_media > 60)
            {
                Console.WriteLine("O governante será reeleito");
            }
            else
            {
                Console.WriteLine("O governante não irá se reeleger");
            }
            
            Console.ReadKey();    
        }
    }
}
