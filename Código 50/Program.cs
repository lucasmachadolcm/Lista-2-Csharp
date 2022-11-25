using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            bool acertou = false;
            int chute;
            int tentativas = 0;


            int numero = gerador.Next(100);

            while (acertou == false)
            {
                Console.WriteLine("Digite um número de 0 a 100: ");
                chute = int.Parse(Console.ReadLine());
                tentativas++;
                if (chute == numero)
                {
                    Console.WriteLine("Você acertou em " + tentativas + " tentativas!");
                    acertou = true;
                }
                else if (chute > numero)
                {
                    Console.WriteLine("O número é menor.");
                }
                else
                {
                    Console.WriteLine("O número é maior.");
                }
            }
            Console.ReadLine();
        }
    }
}
