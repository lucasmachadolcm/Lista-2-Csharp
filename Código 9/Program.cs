using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano = 0;
            int mes = 0;
            int dia = 0;
            int convert_mes = 0;
            int convert_dia = 0;

            Console.WriteLine("Digite a idade da pessoa: ");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o meses que se passaram do aniversário: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os dias que se passaram do fechamento do mês: ");
            dia = int.Parse(Console.ReadLine());
            convert_mes = (ano * 12) + mes;
            convert_dia = (convert_mes * 30) + 30;
            Console.WriteLine("A pessoa possui " + convert_mes + " meses de vida");
            Console.WriteLine("A pessoa possui " + convert_dia + " dias de vida");
            Console.ReadLine();
        }
    }
}
