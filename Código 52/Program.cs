using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_posi = 100;
            int x = 0;
            int[] num = new int[num_posi];
            int contar1 = 0;
            int contar3 = 0;
            int contar4 = 0;
            do
            {
                Console.WriteLine("Digite um número: ");
                num[x] = int.Parse(Console.ReadLine());
                if (num[x] == 1) contar1++;
                if (num[x] == 3) contar3++;
                if (num[x] == 4) contar4++;
                x++;
                Console.WriteLine("Digite -1 para sair");
            } while (num[x - 1] != -1 && x < num_posi);

            Console.WriteLine("Quantidades:\nNumero 1 = " + contar1 + "\nNumero 3 = " + contar3 + "\nNumero 4 = " + contar4);
            Console.ReadLine();
        }
    }
}
