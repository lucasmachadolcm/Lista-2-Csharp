using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int mult = 0;
            int num_1 = 0;
            int num_2 = 0;
            int num_3 = 0;
            int num_4 = 0;

            Console.WriteLine("Digite o número A: ");
            num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número B: ");
            num_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número C: ");
            num_3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número D: ");
            num_4 = int.Parse(Console.ReadLine());

            soma = num_1 + num_2;
            mult = num_1 * num_2;

            Console.WriteLine("A soma de A e B é: " + soma);
            Console.WriteLine("A multiplicação de A e B é: " + mult);

            soma = 0;
            mult = 0;
            soma = num_1 + num_3;
            mult = num_1 * num_3;

            Console.WriteLine("A soma de A e C é: " + soma);
            Console.WriteLine("A multiplicação de A e C é: " + mult);

            soma = 0;
            mult = 0;
            soma = num_1 + num_4;
            mult = num_1 * num_4;

            Console.WriteLine("A soma de A e D é: " + soma);
            Console.WriteLine("A multiplicação de A e D é: " + mult);

            soma = 0;
            mult = 0;
            soma = num_2 + num_3;
            mult = num_2 * num_3;

            Console.WriteLine("A soma de B e C é: " + soma);
            Console.WriteLine("A multiplicação de B e C é: " + mult);

            soma = 0;
            mult = 0;
            soma = num_2 + num_4;
            mult = num_2 * num_4;

            Console.WriteLine("A soma de B e D é: " + soma);
            Console.WriteLine("A multiplicação de B e D é: " + mult);

            soma = 0;
            mult = 0;
            soma = num_3 + num_4;
            mult = num_3 * num_4;

            Console.WriteLine("A soma de C e D é: " + soma);
            Console.WriteLine("A multiplicação de C e D é: " + mult);

            Console.ReadLine();
        }
    }
}
