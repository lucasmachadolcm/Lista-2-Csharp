using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Código_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            double soma = 0;
            double subtracao = 0;
            double multi = 0;
            double divi = 0;
            double n1 = 0;
            double n2 = 0;

            Console.WriteLine("Digite a opção de operação");
            Console.WriteLine("1 - Para soma");
            Console.WriteLine("2 - Para subtração");
            Console.WriteLine("3 - Para multiplicação");
            Console.WriteLine("4 - Para divisão");
            op = int.Parse(Console.ReadLine()); 

            switch (op)
            {
                case 1:

                    Console.WriteLine("Digite o primeiro número");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número");
                    n2 = double.Parse(Console.ReadLine());
                    soma = n1 + n2;
                    Console.WriteLine("O resultado da soma é: "+soma);
                    break;

                case 2:

                    Console.WriteLine("Digite o primeiro número");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número");
                    n2 = double.Parse(Console.ReadLine());
                    subtracao = n1 - n2;
                    Console.WriteLine("O resultado da soma é: " + subtracao);
                    break;

                case 3: 

                    Console.WriteLine("Digite o primeiro número");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número");
                    n2 = double.Parse(Console.ReadLine());
                    multi = n1 * n2;
                    Console.WriteLine("O resultado da soma é: " + multi);
                    break;

                case 4:

                    Console.WriteLine("Digite o primeiro número");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número");
                    n2 = double.Parse(Console.ReadLine());
                    divi = n1 / n2;
                    Console.WriteLine("O resultado da soma é: " + divi);
                    break;
            }
            Console.ReadLine();

        }
    }
}
