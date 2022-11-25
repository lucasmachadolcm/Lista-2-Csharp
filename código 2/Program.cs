using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace código_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cot_dolar = 0;
            double dolar = 0;
            double convert_real = 0;
            Console.WriteLine("Qual a cotação atual do dolar?");
            cot_dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor em dolar se deseja converter?");
            dolar = double.Parse(Console.ReadLine());
            convert_real = cot_dolar * dolar;
            Console.WriteLine("O valor em real é: " + convert_real);
            Console.ReadLine();
        }
    }
}
