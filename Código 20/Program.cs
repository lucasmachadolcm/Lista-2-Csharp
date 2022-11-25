using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;
            int C = 0;
            int maior = 0;
            int medio = 0;
            int menor = 0;
            int divi = 0;
            int mult = 0;

            Console.WriteLine("Digite o primeiro número: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            C = int.Parse(Console.ReadLine());

            while (A < 0)
            {

                Console.WriteLine("Digite o primeiro número: ");
                A = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um valor válido");
                Console.ReadLine();
            }
            while (B < 0)
            {

                Console.WriteLine("Digite o segundo número: ");
                B = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um valor válido");
                Console.ReadLine();
            }
            while (C < 0)
            {
                Console.WriteLine("Digite o terceiro número: ");
                C = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um valor válido");
                Console.ReadLine();
            }
            do
            {
                        
                

                    if (A > B && B > C)
                    {
                        maior = A;
                        medio = B;
                        menor = C;
                        divi = maior / menor;
                        mult = menor * maior;
                        Console.WriteLine("O maior valor é: " + maior + " e o menor é: " + menor);
                        Console.WriteLine("A multiplicação do menor pelo maior é: " + mult);
                        Console.WriteLine("A divisão do maior pelo maior é: " + divi);
                        Console.ReadLine();
                    
                    }
                    else if (B > A && A > C)
                    {
                        maior = B;
                        medio = A;
                        menor = C;
                        divi = maior / menor;
                        mult = menor * maior;
                        Console.WriteLine("O maior valor é: " + maior + " e o menor é: " + menor);
                        Console.WriteLine("A multiplicação do menor pelo maior é: " + mult);
                        Console.WriteLine("A divisão do maior peloo maior é: " + divi);
                        Console.ReadLine();
                    }
                    else
                    {
                        maior = C;
                        medio = A;
                        menor = B;
                        divi = maior / menor;
                        mult = menor * maior;
                        Console.WriteLine("O maior valor é: " + maior + " e o menor é: " + menor);
                        Console.WriteLine("A multiplicação do menor pelo maior é: " + mult);
                        Console.WriteLine("A divisão do maior pelo menor é: " + divi);
                        Console.ReadLine();
                    }
                


            } while (A >= 0 && B >= 0 && C >= 0);
            Console.ReadLine();
        }

    }
}

    

