using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            Array.Reverse(numeros);
            Console.Write("\n\n");
            foreach (int i in numeros) Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
