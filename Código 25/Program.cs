using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            double altura = 0;
            decimal calc = 0;
            Console.WriteLine("Digite o sexo da pessoa para análise. F para feminino e M para masculino");
            sexo = (Console.ReadLine());
            Console.WriteLine("Digite a altura");
            altura = double.Parse(Console.ReadLine());


            if (sexo == "F")
            {
                calc = (decimal)((altura * 62.1) - 44.7);
                Console.WriteLine("O pesso ideal seria: " + calc);
            }
            else
            {
                calc = (decimal)((altura * 72.7) - 58);
                Console.WriteLine("O pesso ideal seria: " + calc);
            }
            Console.ReadLine();
        }
    }
}
