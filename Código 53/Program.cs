using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_voltas = 0;
            int total = 0;
            int media = 0;
            int melhor_tempo = 0;
            int melhor_volta = 0;

            Console.WriteLine("Digite o número de voltas: ");
            num_voltas = int.Parse(Console.ReadLine());

            int[] tempos = new int[num_voltas];
            for (int x = 0; x < num_voltas; x++)
            {
                Console.WriteLine("Digite o tempo da " + (x + 1) + "ª volta (em segundos): ");
                tempos[x] = int.Parse(Console.ReadLine());
                total += tempos[x];
                if (tempos[x] < melhor_tempo || x == 0)
                {
                    melhor_tempo = tempos[x];
                    melhor_volta = x + 1;
                }
            }
            media = total / num_voltas;


            Console.WriteLine("i.   O melhor tempo foi: " + melhor_tempo + " segundos.");
            Console.WriteLine("ii.  Melhor volta foi a " + melhor_volta + "ª.");
            Console.WriteLine("iii. A média de tempo foi: " + media);
            Console.ReadLine();
        }
    }
}
