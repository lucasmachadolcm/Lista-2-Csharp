using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(Verifica(num));
            Console.ReadLine();
        }
        public static String Verifica(int num)
        {
            if (num % 2 == 0) return "PAR";
            else return "ÍMPAR";
        }
    }
    
}
