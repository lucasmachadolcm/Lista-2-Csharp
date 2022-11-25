using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int maior = 0;
            int menor = 0;

            
            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            
            menor = numero;
            maior = numero;
            
            do
            {
                Console.WriteLine("Para finalizar o programa, digite 0");
                Console.WriteLine("Digite outro número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > maior) maior = numero;
                if (numero < menor && numero != 0) menor = numero;

            } while (numero != 0);

            Console.WriteLine("\nO menor número é " + menor + " e o maior número é " + maior + ".");
            Console.ReadLine();
        }
    }
}
