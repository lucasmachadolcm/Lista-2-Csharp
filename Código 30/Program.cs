using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            double conta = 0;
            Console.WriteLine("Digite um número: ");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int x = 0; x <= 10; x++)
            {
                conta = x * n;
                Console.WriteLine(x + " x " + n + " é igual: " + conta);
            }
            Console.ReadLine();
        }
    }
}
