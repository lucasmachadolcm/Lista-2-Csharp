using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int[] fato = new int[n];

            Console.WriteLine("Digite a quantidade de números: ");
            n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n];
            for (int x = 0; x < numeros.Length; x++)
            {
                Console.WriteLine("Digite um número: ");
                numeros[x] = int.Parse(Console.ReadLine());
            }
            for (int x = 0; x < numeros.Length; x++)
            {
                int resultado = 1;
                for (int y = numeros[x]; y > 0; y--)
                {
                    resultado = y * resultado;
                }
                Console.WriteLine("O fatorial de " + numeros[x] + " é: " + resultado);
                Console.ReadLine();
            }
        }
    }
}
