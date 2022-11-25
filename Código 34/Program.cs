using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int maior = 0;
            int menor = 0;
            bool primeiro = true;

            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número negativo para sair do programa");
            if (n >= 0)
            {
                menor = n;
                maior = n;
                while (n >= 0)
                {
                    Console.WriteLine("Digite outro número: ");
                    n = int.Parse(Console.ReadLine());
                    if (n > maior)
                    {
                        maior = n;
                    }
                    if (n < menor && n >= 0)
                    {
                        menor = n;
                    }
                }
            }
            Console.WriteLine("\nO maior número foi " + maior + " e o menor foi " + menor);
            Console.ReadLine();
        }
    }
}
