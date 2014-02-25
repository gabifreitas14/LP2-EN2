using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contarvogais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a mesagem:");
            string frase = Console.ReadLine();
            int x = frase.Length;     
            char[] v = new char[x];
            int contador = 0;

            for (int i = 0; i < x; i++)
                if (frase.Contains('a') || frase.Contains('e') || frase.Contains('i') || frase.Contains('o') || frase.Contains('u'))
                    contador++;

            if (contador != 0)
            {
                if (contador == 1)
                    Console.WriteLine("A mensagem tem " + contador + " vogal");
                else
                    Console.WriteLine("A mensagem tem " + contador + " vogais");
            }
            else
                Console.WriteLine("A mesagem não tem vogais");

        }
    }
}
