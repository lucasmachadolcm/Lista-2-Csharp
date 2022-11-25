using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0; 
            int C = 0;
            int soma = 0;
            Console.WriteLine("Digite o lado A do triângulo");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado B do triângulo");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado C do triângulo");
            C = int.Parse(Console.ReadLine());  
            if (A < B + C && B < A +C && C < A + B)
            {
                if( A == B & B == C)
                {
                    Console.WriteLine("O Triângulo é equilátero");
                }
                else if (A == B && A == C && B == C)
                {
                    Console.WriteLine("O Triângulo é isósceles");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os valores não podem ser de um triângulo");
            }
            Console.ReadLine();
        }
    }
}
