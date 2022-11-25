using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_comp = 0;

            Console.WriteLine("Digite o número de posições: ");
            num_comp = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int[] v1 = new int[num_comp];
            int[] v2 = new int[num_comp];

            for (int x = 0; x < num_comp; x++)
            {
                Console.WriteLine("Digite um valor para a posição " + (x + 1) + " do vetor 1: ");
                v1[x] = int.Parse(Console.ReadLine());
            }
            for (int x = 0; x < num_comp; x++)
            {
                Console.WriteLine("Digite um valor para a posição " + (x + 1) + " do vetor 2: ");
                v2[x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            for (int x = 0; x < num_comp; x++)
            {
                if (v1[x] == v2[x])
                {
                    Console.WriteLine("Valores das Posições " + (x + 1) + " dos vetores é igual.");
                }
            }
            Console.ReadLine();
        }
    }
}
