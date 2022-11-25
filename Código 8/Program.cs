using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double V = 0;
            double R = 0;
            double A = 0;
            Console.WriteLine("Cálculo de Volume de latas");
            Console.WriteLine("Digite o raio: ");
            R = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            A = double.Parse(Console.ReadLine());
            V = 3.14159 * R * R * A;
            Console.WriteLine("O volume da lata é: " + V + " unidade ³");
            Console.ReadLine();
        }
    }
}
