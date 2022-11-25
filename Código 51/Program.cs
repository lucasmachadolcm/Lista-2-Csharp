using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aluno_quant;
            int nota_a = 0;
            bool sala_menor_nota = true;

            Console.WriteLine("Digite a quantidade de alunos: ");
            aluno_quant = int.Parse(Console.ReadLine());

            int[] notas = new int[aluno_quant];

            for (int x = 0; x < aluno_quant; x++)
            {
                Console.WriteLine("Digite a nota do " + (x + 1) + "° Aluno: ");
                notas[x] = int.Parse(Console.ReadLine());

                if (notas[x] >= 70)
                {
                    nota_a++;
                }
                else if (notas[x] < 70 || notas[x] > 50)
                {
                    sala_menor_nota = false;
                }
            }

            if (sala_menor_nota == false)
            {
                Console.WriteLine("Existem " + nota_a + " notas maiores que 7.");
            }
            else
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5.");
            }
            Console.ReadLine();
        }
    }
}
