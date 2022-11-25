using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int quadrado = 0;
            int resultado = 0;
            int x = 0;
            do
            {
                Console.WriteLine("Digite um número entre 0 e 10: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n >= 10);

            for (x = n; x < 40 + n; x++)
            {
                if (x % 2 == 1)
                {
                    resultado += x * x;
                }
            }
            Console.WriteLine("O resultado da soma dos quadrados dos 20 primeiros números inteiros positivos ímpares a partir do número informado é: " + resultado);
            Console.ReadLine();
        }
    }
}
