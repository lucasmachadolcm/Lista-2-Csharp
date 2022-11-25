using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quant_al = 0;
            string matricula;
            double media_alunos = 0;
            double nota = 0;

            Console.WriteLine("Digite um a quantidade de alunos: ");
            quant_al = int.Parse(Console.ReadLine());

            Aluno[] alunos = new Aluno[quant_al];

            for (int x = 0; x < quant_al; x++)
            {
                Console.WriteLine("\nDigite o número da matrícula do aluno: ");
                matricula = Console.ReadLine();
                Console.WriteLine("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());
                alunos[x] = new Aluno();
                alunos[x].setAluno(matricula, nota);
                media_alunos += nota;
            }
            media_alunos = media_alunos / quant_al;
            Console.WriteLine("\nA média da turma foi de " + media_alunos);
            Console.ReadLine();
        }
    }
}
