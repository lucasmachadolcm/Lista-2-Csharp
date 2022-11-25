using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int par = 0;
            int impar = 0;

            while (n >= 0)
            {

                Console.WriteLine("Digite um número inteiro positivo: ");
                n = int.Parse(Console.ReadLine());
                if (n >= 0)
                {
                    if (n % 2 == 0)
                    {
                        par++;
                    }
                    else
                    {
                        impar++;
                    }
                }
                Console.WriteLine("Para fechar o programa digite um número negativo");
            }

            Console.WriteLine("\n\nQuantidade de Números Pares: " + par + "\nQuantidade de Números Impares: " + impar);
            Console.ReadLine();
        }
    }
}
