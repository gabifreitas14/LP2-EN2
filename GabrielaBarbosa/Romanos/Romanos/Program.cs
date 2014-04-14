using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula1;

namespace Romanos
{
    class Program
    {
        static void Main(string[] args)
        {
            IBGE converteromano = new IBGE();

            int numero = int.Parse(Console.ReadLine());
            
            Console.WriteLine(converteromano.ConverteDecimalParaRomano(numero));

        }
    }
}
