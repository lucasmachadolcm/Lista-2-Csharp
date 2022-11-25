using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_22
{
 
         
        internal class Program
        {
            static void Main(string[] args)
            {
                int num = 0;
                int A = 0;
                int B = 0;
                string cont;
                do
                {
                    Console.WriteLine("Digite o número");
                    num = int.Parse(Console.ReadLine());
                    if (num >= 0)
                    {
                        A = num;
                        Console.WriteLine("O número é positivo: "+ A);
                    }
                    else
                    {

                        B = num;
                        Console.WriteLine("O número é negativo: " +B);
                    }
                    Console.WriteLine("Deseja fazer outra verificação? Digite S para sim e N para não");
                    cont = Console.ReadLine();
                } while (cont == "S");
                Console.ReadLine();
            }
        }
    
}
    

