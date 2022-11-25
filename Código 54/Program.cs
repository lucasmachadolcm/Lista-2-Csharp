using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            int[] B = new int[8];
            int[] C = new int[5];
            //List<Integer> C = new ArrayList<Integer>();
            int w = 0;
            int x = 0;
            int y = 0;

            for (x = 0; x < 5; x++)
            {
                Console.WriteLine("Digite um número para o vetor A: ");
                A[x] = int.Parse(Console.ReadLine());
            }
            for (x = 0; x < 8; x++)
            {
                Console.WriteLine("Digite um número para o vetor B: ");
                B[x] = int.Parse(Console.ReadLine());
                for (y = 0; y < 5; y++)
                {
                    if (B[x] == A[y])
                    {
                        C[w] = (A[y], B[x]);
                        w++;
                    }
                }
            }
            Console.WriteLine("Números comuns: ");
            for (x = 0; x < C[5](); x++)
            {

                Console.WriteLine(C.Get(x) + " ");
            }
            Console.WriteLine();
        }
       			
					

    }
    
}
