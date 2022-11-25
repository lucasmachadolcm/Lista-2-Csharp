using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int aux = 0;
            Console.WriteLine("Digite o valor de A: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            num2 = int.Parse(Console.ReadLine());
            aux = num1;
            num1 = num2;
            num2 = aux;
            Console.WriteLine("O valor de A é: " + num1 + " e o valor de B é: " + num2);
            Console.ReadLine();
        }
    }
}
