using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Digite um número entre 0 e 9");
            num = int.Parse(Console.ReadLine());
            if (num >= 0 && num <= 9)
            {
                Console.WriteLine("Valor válido");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
            Console.ReadLine();

        }
    }
}
