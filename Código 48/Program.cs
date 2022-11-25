using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroCandidatas = 5;
            int quantidade_aptas = 0;
            string[] nome = new String[numeroCandidatas];
            int[] idade = new int[numeroCandidatas];



            for (int x = 0; x < numeroCandidatas; x++)
            {
                Console.WriteLine("Digite o nome da " + (x + 1) + "ª candidata: ");
                nome[x] = Console.ReadLine();

                Console.WriteLine("Digite a idade da " + (x + 1) + "ª candidata: ");
                idade[x] = int.Parse(Console.ReadLine());

                if (idade[x] >= 18 && idade[x] < 21)
                {
                    quantidade_aptas++;
                }
            }


            String[] nome_aptas = new String[quantidade_aptas];
            int[] idade_aptas = new int[quantidade_aptas];

            int y = 0;
            for (int x = 0; x < numeroCandidatas; x++)
            {
                if (idade[x] >= 18 && idade[x] < 21)
                {
                    nome_aptas[y] = nome[x];
                    idade_aptas[y] = idade[x];
                    y++;
                }
            }

            Console.WriteLine();

            for (int x = 0; x < quantidade_aptas; x++)
            {
                Console.WriteLine("Nome: " + nome_aptas[x] + " Idade: " + idade_aptas[x]);
            }
            Console.ReadLine();
        }
    }
}
