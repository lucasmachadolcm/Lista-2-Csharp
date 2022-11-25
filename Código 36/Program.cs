using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quant_numero = 10;
            double media = 0;
            int[] numeros = new int[quant_numero];

            for (int x = 0; x < quant_numero; x++)
            {
                Console.WriteLine("Digite o " + (x + 1) + "° número: ");
                numeros[x] = int.Parse(Console.ReadLine());
                media += numeros[x];
            }
            media = media / quant_numero;
            Array.Sort(numeros);

            Console.WriteLine("\nO menor número é: " + numeros[0]);
            Console.WriteLine("O maior número é: " + numeros[quant_numero - 1]);
            Console.WriteLine("A média dos números é: " + media);
            Console.ReadLine();
        }
    }
}
