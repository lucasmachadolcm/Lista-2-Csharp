using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quant = 0;
            double media = 0;
            int x = 0;
            Console.WriteLine("Digite a quantidade de números: ");

            quant = int.Parse(Console.ReadLine());
            int[] numeros = new int[quant];

            for (x = 0; x < quant; x++)
            {
                Console.WriteLine("Digite o valor " + (x + 1) + ": ");
                numeros[x] = int.Parse(Console.ReadLine());
                media += numeros[x];
            }
            media = media / quant;
            Array.Sort(numeros);

            Console.WriteLine("A média dos valores é: " + media + "\nO maior valor é: " + numeros[quant - 1]);
            Console.ReadLine();
        }
    }
}
