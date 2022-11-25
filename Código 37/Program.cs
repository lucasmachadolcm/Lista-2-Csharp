using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            string charOpcao;
            bool encerrar = false;
            double primeiro = 0;
            double segundo = 0;
                       

            while (encerrar == false)
            {

                Console.WriteLine("Digite uma das opções para as operações:\n1 – Adição\n2 – Subtração\n3 – Multiplicação\n4 – Divisão\nopção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o primeiro número: ");
                        primeiro = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número: ");
                        segundo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado de " + primeiro + "+" + segundo + "=" + (primeiro + segundo));
                        break;
                    case 2:
                        Console.WriteLine("Digite o primeiro número: ");
                        primeiro = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número: ");
                        segundo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado de " + primeiro + "-" + segundo + "=" + (primeiro - segundo));
                        break;
                    case 3:
                        Console.WriteLine("Digite o primeiro número: ");
                        primeiro = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número: ");
                        segundo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado de " + primeiro + "*" + segundo + "=" + (primeiro * segundo));
                        break;
                    case 4:
                        Console.WriteLine("Digite o primeiro número: ");
                        primeiro = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número: ");
                        segundo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado de " + primeiro + "/" + segundo + "=" + (primeiro / segundo));
                        break;
                    default:
                        Console.WriteLine("Opção inválida, digite novamente a opção: ");
                        opcao = int.Parse(Console.ReadLine());
                        break;
                }
                Console.WriteLine("Deseja continuar?(s/n)");
                charOpcao = Console.ReadLine();
                if (charOpcao == "N" || charOpcao == "n")
                {
                    encerrar = true;
                }
            }

        }
               
    }
    
}
