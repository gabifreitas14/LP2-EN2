using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testegit

{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Escreva aqui a mensagem que voce quer contar as vogais.");

            string read = Console.ReadLine();

            int r = read.Count();

            ArrayList arrays = new ArrayList();

            foreach (char array in read)
            {
                arrays.Add(array);
           
            }

            for (int i = 0; i < arrays.Count; i++)
            {
                
                if (arrays[i].ToString() == "a")
                {
                    count++;
                }

                else if (arrays[i].ToString() == "e")
                {
                    count++; 
                }

                else if (arrays[i].ToString() == "i")
                {
                    count++; 
                }

                else if (arrays[i].ToString() == "o")
                {
                    count++;
                }

                else if (arrays[i].ToString() == "u")
                {
                    count++;
                }

                if (arrays[i].ToString() == "A")
                {
                    count++;
                }

                else if (arrays[i].ToString() == "E")
                {
                    count++;
                }

                else if (arrays[i].ToString() == "I")
                {
                    count++;
                }

                else if (arrays[i].ToString() == "O")
                {
                    count++;
                }

                else if (arrays[i].ToString() == "U")
                {
                    count++;
                }


            }

            if (count > 0)
            {
                Console.WriteLine("A mensagem tem " + count + " vogais.");
            }
            else
            {
                Console.WriteLine("A mensagem nao tem vogais.");
            }
            

        }

    }
}
        
