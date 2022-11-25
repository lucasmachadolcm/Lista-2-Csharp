using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double base_tr = 0;
            double altura = 0;
            Console.WriteLine("Digite o tamanho da base: ");
            base_tr = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tamanho da altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("A hipotenusa é : " + Hipotenusa(base_tr, altura));
            Console.ReadLine();
        }
        public static double Hipotenusa(double Base, double Altura)
        {
            double hipotenusa = ((Base * Base) + (Altura * Altura));
            hipotenusa = Math.Sqrt(hipotenusa);
            return hipotenusa;
        }
    }
    
}
