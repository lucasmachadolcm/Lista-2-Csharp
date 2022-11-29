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
            int[] vet1 = new int[5];
            int[] vet2 = new int[8];
            int[] vetigual = null;
                
            
            int tamanhoArray = vet2.Count();
            vetigual = new int[tamanhoArray];

            for (int x = 0; x < vet1.Count(); x++)
            {
               Console.WriteLine("Digite o "+(x+1)+"º número para o vetor 1: ");
              vet1[x] = int.Parse(Console.ReadLine());

                for (int y = 0; y < vet2.Count(); y++)
                {
                    Console.WriteLine("Digite o " + (y + 1) + "º número para o vetor 2: ");
                    vet2[y] = int.Parse(Console.ReadLine());
                    if (vet1[x] == vet2[y])
                    {
                        vetigual[y] = vet2[y];
                                              
                    }

                }
               
            }
            if (vetigual != null)
            {
                int contador = 0;
                Console.WriteLine("Os valores encontrados foram:");
                foreach (var item in vetigual)
                {
                    if (item != 0)
                    {
                        contador++;
                        Console.WriteLine(item);
                    }
                }

                if (contador == 0)
                {
                    Console.WriteLine("Não foram encontrados valores iguais");
                }
                                
            }
                Console.ReadLine();


        }
       						

    }
    
}
