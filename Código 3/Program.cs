using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod_ven = 0;
            int cod_pec = 0;
            int quant = 0;
            double valor_pec = 0;
            double valor_total = 0;
            double valor_comicao = 0;
            Console.WriteLine("Digite o código do vendedor: ");
            cod_ven = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código da peça: ");
            cod_pec = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade: ");
            quant = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da peça");
            valor_pec = double.Parse(Console.ReadLine());
            valor_total = quant * valor_pec;
            valor_comicao = valor_total * 0.05;
            Console.WriteLine("O valor total da peça é: " + valor_total);
            Console.WriteLine("O valor da comissão do vendedor é: " + valor_comicao);
            Console.ReadLine();
        }
    }
}
