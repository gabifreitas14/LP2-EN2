﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Aula1
{
    public class IBGE
    {
        double medias= 0;
        double min = 0;
        double max = 0;
        int abaixo = 0;
        int acima = 0;
        int nmedia = 0;
        double soma = 0;
        double variancia = 0;
        double porcentagemacima = 0;
        double porcentagemabaixo = 0;
        double [] desvio;
        double[] quadrado;
        
         public double media(double total, int nota) 
        { 
            
            medias = total / nota;
            return medias;
        }
        public double minimo(double [] array, int nota)
         {
             min= array[1];
             for (int i = 1; i < nota+1; i++)
             { 
                 if (array[i] < min)
             {
                 min = array[i];
             }
                 
             }
             return min;
            
         }
        public double maximo(double[] array, int nota)
        {
            max = array[1];
            for (int i = 1; i < nota + 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

            }
            return max;

        }
        public double abaixodamedia(double[] array, int nota)
        {
            
            for (int i = 1; i < nota + 1; i++)
            {
                if (medias > array[i])
                {
                    abaixo++;
                }

            }
            return abaixo;

        }

        public double acimadamedia(double[] array, int nota)
        {

            for (int i = 1; i < nota + 1; i++)
            {
                if (medias < array[i])
                {
                    acima++;
                }

            }
            return acima;

        }
        public double namedia(double[] array, int nota)
        {

            for (int i = 1; i < nota + 1; i++)
            {
                if (medias == array[i])
                {
                    nmedia++;
                }

            }
            return nmedia;

        }
        public double desviop(double[] array, int nota)
        {
            desvio = new double[nota+1];

            quadrado = new double [nota+1];

            for (int i = 1; i < nota + 1; i++)
            {
                

                desvio[i] = (array[i] - medias);

                quadrado[i] = desvio[i] * desvio[i];

                soma = quadrado[i] + soma;

            }
            variancia = Math.Sqrt(soma / medias);

            return variancia;
        }
        public double porcentacima(int nota)
        {
            porcentagemacima = (100 * acima) / nota;

            return porcentagemacima;
            
        }

        public double porcentabaixo(int nota)
        {
            porcentagemabaixo = (100 * abaixo) / nota;

            return porcentagemabaixo;

        }

        public string status(double total)
        {
            if (total >= 4.87 && porcentagemacima >= 60)
               return "O governante vai ser reeleito ";

            else
                return "O governante não será reeleito";
            
        }
        public string statu(double media)
        {
            if (media < 5.5)
            {
                return "Reprovado";
            }
            if (media < 6)
            {
                return "Pendente COC";
            }

            return "Aprovado";
        }
        public string ConverteDecimalParaRomano(int numero)
        {
            string resposta = "";



            if (0 < numero && numero <= 3999)
            {
                while (numero > 0)
                {
                    if (numero >= 1000)
                    {
                        resposta += "M";
                        numero -= 1000;
                        continue;
                    }

                    if (numero >= 900)
                    {
                        resposta += "CM";
                        numero -= 900;
                        continue;
                    }

                    if (numero >= 500)
                    {
                        resposta += "D";
                        numero -= 500;
                        continue;
                    }
                    if (numero >= 400)
                    {
                        resposta += "CD";
                        numero -= 400;
                        continue;
                    }
                    if (numero >= 100)
                    {
                        resposta += "C";
                        numero -= 100;
                        continue;
                    }
                    if (numero >= 90)
                    {
                        resposta += "XC";
                        numero -= 90;
                        continue;
                    }
                    if (numero >= 50)
                    {
                        resposta += "L";
                        numero -= 50;
                        continue;
                    }
                    if (numero >= 40)
                    {
                        resposta += "XL";
                        numero -= 40;
                        continue;
                    }
                    if (numero >= 10)
                    {
                        resposta += "X";
                        numero -= 10;
                        continue;
                    }
                    if (numero >= 9)
                    {
                        resposta += "IX";
                        numero -= 9;
                        continue;
                    }
                    if (numero >= 5)
                    {
                        resposta += "V";
                        numero -= 5;
                        continue;
                    }
                    if (numero >= 4)
                    {
                        resposta += "IV";
                        numero -= 4;
                        continue;
                    }
                    if (numero >= 1)
                    {

                        resposta += "I";
                        numero -= 1;


                    } 

                }
                
               return resposta;

            } 
      
            else
	{
        return "Não existe";
	}
            
        }
        
        

           } 

        }
   
