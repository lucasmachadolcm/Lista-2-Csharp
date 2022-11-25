using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:

                    Console.WriteLine("um");  
                    break;

                case 2:

                    Console.WriteLine("dois");
                    break ;

                case 3:

                    Console.WriteLine("três");
                    break;

                default:

                    Console.WriteLine("Código inválido");
                    break;

            }
            Console.ReadLine();
        }
    }
}
