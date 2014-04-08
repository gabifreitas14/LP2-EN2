using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            string resposta = ""; 

            if (0<numero&&numero<=3999)
            {
                while (numero>0)
                {
                    if (numero>=1000)
                    {
                        resposta += "M";
                        numero -= 1000;
                        continue;
                    }

                    if (numero>=900)
                    {
                        resposta += "CM";
                        numero -= 900;
                        continue;
                    }

                    if (numero>=500)
                    {
                        resposta += "D";
                        numero -= 500;
                        continue;
                    }
                    if (numero>=400)
                    {
                        resposta += "CD";
                        numero -= 400;
                        continue;
                    }
                    if (numero>=100)
                    {
                        resposta += "C";
                        numero -= 100;
                        continue;
                    }
                    if (numero>=90)
                    {
                        resposta += "XC";
                        numero -= 90;
                        continue;
                    }
                    if (numero>=50)
                    {
                        resposta += "L";
                        numero -= 50;
                        continue;
                    }
                    if (numero>=40)
                    {
                        resposta += "XL";
                        numero -= 40;
                        continue;
                    }
                    if (numero>=10)
                    {
                        resposta += "X";
                        numero -= 10;
                        continue;
                    }
                    if (numero>=9)
                    {
                        resposta += "IX";
                        numero -= 9;
                        continue;
                    }
                    if (numero>=5)
                    {
                        resposta += "V";
                        numero -= 5;
                        continue;
                    }
                    if (numero>=4)
                    {
                        resposta += "IV";
                        numero -= 4;
                        continue;
                    }
                    if (numero>=1)
                    {
                       
                        resposta += "I";
                        numero -= 1;
                        
                        
                    }
                    

	
                } 
                Console.WriteLine(resposta);
            }
            else 
            {
                Console.WriteLine("Não existe");
            }

            

        }
    }
}
