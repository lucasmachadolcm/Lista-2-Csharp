using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario_atual = 0;
            double reajuste = 0;

            Console.WriteLine("Digite o salario atual: ");
            salario_atual = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual de reajuste: ");
            reajuste = (double.Parse(Console.ReadLine()) / 100);
            Console.WriteLine("O novo salário é: " + Reajuste(salario_atual, reajuste) + ".");
            Console.ReadLine();
        }
        public static double Reajuste(double Salario, double IndiceReajuste)
        {
            double NovoSalario = Salario + (Salario * IndiceReajuste);
            return NovoSalario;
        }

    
}
    
}
