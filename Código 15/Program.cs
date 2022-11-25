using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0;
            double n2 = 0;
            double n3 = 0;
            double n4 = 0;
            double rec = 0;
            double media = 0;

            Console.WriteLine("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota: ");
            n4 = double.Parse(Console.ReadLine());
            media = (n1 + n2 + n3 + n4) / 4;
            if (media >= 70)
            {
                Console.WriteLine("Aluno aprovado com nota: " + media);
            }
            else
            {
                Console.WriteLine("Digite a nota da prova de recuperação: ");
                rec = double.Parse(Console.ReadLine());
                media = (media + rec) / 2;
                if (media >= 70)
                {
                    Console.WriteLine("Aluno aprovado com nota: " + media);
                }
                else
                {
                    Console.WriteLine("Aluno reprovado. Sua média foi: " + media);
                }

            }
            Console.ReadLine();
        }
    }
}
