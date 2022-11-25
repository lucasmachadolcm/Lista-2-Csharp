using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int estoque_min = 0;
            int estoque_max = 0;
            int estoque_med = 0;
            Console.WriteLine("Digite o estoque mínimo que determinada peça pode ter: ");
            estoque_min = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o estoque máximo que determinada peça pode ter: ");
            estoque_max = int.Parse(Console.ReadLine());
            estoque_med = (estoque_min + estoque_max) / 2;
            Console.WriteLine("O estoque médio é: " + estoque_med);
            Console.ReadLine();
        }
    }
}
