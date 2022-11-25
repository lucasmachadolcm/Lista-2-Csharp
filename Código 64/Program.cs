using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_64
{
    public class Exercicio
    {
        private static int[] Vetor = new int[10];

        public static void Main(string[] args)
        {

            bool continuar = true;
            int opcao = 0;
            
            do
            {

                Console.WriteLine("Digite 1 para carregar o vetor ");
                //opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        CarregarVetor();
                        break;
                    case 2:
                        Console.WriteLine(ListarVetor());
                        break;
                    case 3:
                        Console.WriteLine(ListarParesVetor());
                        break;
                    case 4:
                        Console.WriteLine(ListarImparesVetor());
                        break;
                    case 5:
                        Console.WriteLine(QuantidadeParesNosImparesVetor());
                        break;
                    case 6:
                        Console.WriteLine(QuantidadeImparesNosParesVetor());
                        break;
                    case 7:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Número inválido.");
                        break;
                }
                Console.WriteLine("Digite algums dos números a seguir para continuar: ");
                Console.WriteLine("2 - Para Listar os vetore");
                Console.WriteLine("3 - Para Exibir os números pares do vetor");
                Console.WriteLine("4 - Para Exibir os números ímpares do vetor");
                Console.WriteLine("5 - Para Exibir a quantidade de números pares nas posições ímpares do vetor");
                Console.WriteLine("6 - Para Exibir a quantidade de números ímpares nas posições pares do vetor");
                Console.WriteLine("7 - Para Sair");
                opcao = int.Parse(Console.ReadLine());
            } while(continuar);
        }
        //1 - Carregar Vetor
        public static void CarregarVetor()
        {
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Digite o " + (x + 1) + "° número do vetor: ");
                Vetor[x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nVetor carregado com sucesso!\n");
        }
        //2 - Listar Vetor
        public static String ListarVetor()
        {
            String ListaVetor = "Valores do vetor:\n";
            for (int x = 0; x < 10; x++)
            {
                ListaVetor += "\t" + Vetor[x] + "\n";
            }
            return ListaVetor;
        }
        //3 - Exibir apenas os números pares do vetor
        public static String ListarParesVetor()
        {
            String ListaVetor = "Valores do vetor:\n";
            for (int x = 0; x < 10; x++)
            {
                if (Vetor[x] % 2 == 0)
                {
                    ListaVetor += "\t" + Vetor[x] + "\n";
                }
            }
            return ListaVetor;
        }
        //4 - Exibir apenas os números ímpares do vetor
        public static String ListarImparesVetor()
        {
            String ListaVetor = "Valores do vetor:\n";
            for (int x = 0; x < 10; x++)
            {
                if (Vetor[x] % 2 == 1)
                {
                    ListaVetor += "\t" + Vetor[x] + "\n";
                }
            }
            return ListaVetor;
        }
        //5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor
        public static int QuantidadeParesNosImparesVetor()
        {
            int quantidade = 0;
            for (int x = 1; x < 10; x = x + 2)
            {
                if (Vetor[x] % 2 == 0)
                {
                    quantidade++;
                }
            }
            return quantidade;
        }
        //6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor
        public static int QuantidadeImparesNosParesVetor()
        {
            int quantidade = 0;
            for (int x = 0; x < 10; x = x + 2)
            {
                if (Vetor[x] % 2 == 1)
                {
                    quantidade++;
                }
            }
            return quantidade;
        }
    }
}
