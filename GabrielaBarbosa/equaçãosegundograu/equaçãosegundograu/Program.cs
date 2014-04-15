using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equaçãosegundograu
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());

            double b = int.Parse(Console.ReadLine());

            double c = int.Parse(Console.ReadLine());

            double delta = (b * b) - 4 * a * c;

            Console.WriteLine(delta);

            double raiz1 = (-b + (Math.Sqrt(delta)))/(2*a);

            double raiz2 = (-b - (Math.Sqrt(delta))) / (2 * a);

            Console.WriteLine("As raizes são: {0} e {1}",raiz1,raiz2);

        }
    }
}
