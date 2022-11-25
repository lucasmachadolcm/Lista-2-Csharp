using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string cont;
            do
            {
                Console.WriteLine("Digite o número");
                num = int.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    Console.WriteLine("O número é positivo");
                }
                else
                {
                    Console.WriteLine("O número é negativo");
                }
                Console.WriteLine("Deseja fazer outra verificação? Digite S para sim e N para não");
                cont = Console.ReadLine();
            } while (cont == "S");
            Console.ReadLine();
        }
    }
}
