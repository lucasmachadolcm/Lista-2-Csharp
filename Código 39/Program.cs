using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool parar = false;
            string opcao;

            do
            {
                Console.WriteLine("Digite um número inteiro: ");
                numero = int.Parse(Console.ReadLine());


                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par.\n");
                }
                else
                {
                    Console.WriteLine("O número não é par\n");
                }
                if (numero < 0)
                {
                    Console.WriteLine("O número é negativo\n");
                }
                else
                {
                    Console.WriteLine("O número é positivo\n");
                }

                Console.WriteLine("Deseja sair? (s/N)? ");
                opcao = Console.ReadLine();
                if (opcao == "s" || opcao == "S")
                {
                    parar = true;
                }

            } while (parar == false);

        }
    }
}
