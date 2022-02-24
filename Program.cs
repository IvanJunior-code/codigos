using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                0! = 1
                1! = 1
                2! = 2 · 1 = 2
                3! = 3 · 2 · 1 = 6
                4! = 4 · 3 · 2 · 1 = 24
                5! = 5 · 4 · 3 · 2 · 1 = 120
                6! = 6 · 5 · 4 · 3 · 2 · 1 = 720
                7! = 7 · 6 · 5 · 4 · 3 · 2 · 1 = 5040
                8! = 8 · 7 · 6 · 5 · 4 · 3 · 2 · 1 = 40320
                9! = 9 · 8 · 7 · 6 · 5 · 4 · 3 · 2 · 1 = 362880
                10! = 10 · 9 · 8 · 7 · 6 · 5 · 4 · 3 · 2 · 1 = 3628800
            */

            for (int numero = 0; numero <= 10; numero++)
            {
                int fatorial = 0;
                Console.Write(numero + "! → " + (numero == 0 ? "1" : ""));

                fatorial = numero;
                for (int numeroAnterior = numero; numeroAnterior >= 1; numeroAnterior--)
                {                    
                    Console.Write(numeroAnterior);
                    if (numeroAnterior != 1)
                    {
                        Console.Write(" · ");
                        fatorial = fatorial * (numeroAnterior - 1);
                    } else
                    {
                        Console.Write(" = " + fatorial);
                    }
                }
                Console.WriteLine("");
            }

            Console.ReadLine();

        }
    }
}
