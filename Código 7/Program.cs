using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C = 0;
            double F = 0;
            Console.WriteLine("Digite a temperatura em graus Fahreheit para conversão");
            F = double.Parse(Console.ReadLine());

            C = (F - 32) * 5 / 9;
            Console.WriteLine("A temperatura em Celsius é: " + C);
            Console.ReadLine();
        }
    }
}
