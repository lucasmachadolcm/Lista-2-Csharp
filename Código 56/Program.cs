using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num_int = new int[50];
            int quant_pares = 0;
            int x = 0;

            while (x < 50)
            {
                Console.WriteLine("Digite um número inteiro para a posição " + (x + 1) + ": ");
                num_int[x] = int.Parse(Console.ReadLine());
                if (num_int[x] >= 0)
                {
                    if (num_int[x] % 5 == 0 && num_int[x] % 2 == 0)
                    {
                        quant_pares++;
                    }
                    x++;
                }
            }

            Console.WriteLine("\nA quantidade de números pares e multiplos de 5 é: " + quant_pares);
            Console.ReadLine();
        }
    }
}
