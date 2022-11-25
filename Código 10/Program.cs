using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("O números são iguais");
            }
            else if (num1 != num2)
            {
                Console.WriteLine("Os números não são iguais");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("O primeiro número é maior que o segundo");
            }
            Console.ReadLine(); 
        }
    }
}
