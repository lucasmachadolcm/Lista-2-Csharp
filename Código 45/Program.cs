using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 0;

            int x = 0;

            Console.WriteLine("Digite a quantidade de números: ");
            quantidade = int.Parse(Console.ReadLine());
            int[] Numeros = new int[quantidade];
            for (x = 0; x < quantidade; x++)
            {
                Console.WriteLine("Digite o " + (x + 1) + "° Número: ");
                Numeros[x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A ordem contrária é: ");
            for (int y = quantidade - 1; y >= 0; y--)
            {
                Console.WriteLine(Numeros[y]);
            }
            Console.ReadLine();
        }
    }
}
