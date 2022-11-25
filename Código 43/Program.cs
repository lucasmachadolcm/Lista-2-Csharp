using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double graosCasa = 1;
            double casasTabuleiro = 64;
            double graos = 1;

            for (int x = 1; x < casasTabuleiro; x++)
            {
                graosCasa = graosCasa * 2;
                graos += graosCasa;
            }

            Console.WriteLine("\nO quantidade de grãos é: " + graos);
            Console.ReadLine();
        }
    }
}
