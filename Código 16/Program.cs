using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("O primeiro número é maior");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("O segundo número é maior");
            }
            else
            {
                Console.WriteLine("Os número são iguais");
            }
            Console.ReadLine();
        }
    }
}
