using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int x = 0;
            Console.WriteLine("Programa de cálculo de módulo");
            Console.WriteLine("Digite o valor para cálculo: ");
            num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                x = num;
                Console.WriteLine("O módulo do número é: " + x);
            }
            else
            {
                x = num * (-1);
                Console.WriteLine("O módulo do número é: " + x);
            }

            Console.ReadLine();
        }
    }
}
