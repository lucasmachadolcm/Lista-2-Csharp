using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
             double C = 0;
        double F = 0;
        Console.WriteLine("Digite a temperatura em graus Celsius para conversão");
        C = double.Parse(Console.ReadLine());
        
        F = ( 9 * C + 160) / 5;
        Console.WriteLine("A temperatura em Fahreheit é: " +F);
        Console.ReadLine();
        }
    }
}
