using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int calc = 0;
            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                calc = num1 - num2;
                Console.WriteLine("A diferença dos números é: " + calc);
            }
            else
            {
                calc = num2 - num1;
                Console.WriteLine("A diferença dos números é: " + calc);
            }
            Console.ReadLine();
        }
    }
}
