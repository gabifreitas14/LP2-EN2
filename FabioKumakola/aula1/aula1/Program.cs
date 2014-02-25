using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool erro = false;
            do
            {
                try
                {
                    Class1 pesquisa = new Class1();
                    Console.WriteLine("Quantidade de notas coletadas: ");
                    pesquisa.x = int.Parse(Console.ReadLine());

                    bool continuar = true;

                    while (continuar == true)
                    {
                        if (pesquisa.x > 100000 || pesquisa.x < 0)
                        {
                            Console.WriteLine("Digite um número entre 0 e 100000");
                            pesquisa.x = int.Parse(Console.ReadLine());
                        }
                        else
                            continuar = false;
                    }

                    Console.WriteLine("Digite as notas(elas terão somente 2 casas decimais): ");

                    bool continuar2 = true;

                    while (continuar2 == true)
                    {
                        for (int i = 0; i < pesquisa.x; i++)
                        {
                            pesquisa.n[i] = Math.Round(double.Parse(Console.ReadLine()) * 100) / 100;

                            if (pesquisa.n[i] > 10 || pesquisa.n[i] < 0)
                            {
                                i = -1;
                                Console.WriteLine("Todos os números devem estar entre 0 e 10, redigite os números corretamente: ");
                                for (int j = 0; j < pesquisa.x; j++)
                                    pesquisa.n[j] = 0;
                            }
                            else
                                continuar2 = false;


                        }
                    }

                    Console.WriteLine(pesquisa.rmedia());
                    Console.WriteLine(pesquisa.rmenorvalor());
                    Console.WriteLine(pesquisa.rmaiorvalor());
                    Console.WriteLine(pesquisa.rmenormedia());
                    Console.WriteLine(pesquisa.rmaiormedia());
                    Console.WriteLine(pesquisa.rpmenor());
                    Console.WriteLine(pesquisa.rpmaior());
                    Console.WriteLine(pesquisa.rdp());
                    Console.WriteLine(pesquisa.rmediana());
                    Console.WriteLine(pesquisa.reeleicao());
                }
                catch
                {
                    Console.WriteLine("ERRO!");
                    Console.WriteLine("Insira novamente os dados.");
                    erro = true;
                }

            } while (erro == true);
	    }
    }
}
