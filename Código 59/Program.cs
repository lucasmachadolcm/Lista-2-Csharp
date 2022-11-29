using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] letras = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'w', 'y', 'z' };
            char letra1;
            char letra2;
            int primeiraletra;
            int segundaletra;
            int diferencas;
            Console.WriteLine("Digite a primeira letra: ");
            letra1 = Convert.ToChar(Console.ReadLine());

            primeiraletra = contaletra(letra1, letras);

            Console.WriteLine("Digite a segunda letra: ");
            letra2 = Convert.ToChar(Console.ReadLine());

            segundaletra = contaletra(letra2, letras);


            diferencas = segundaletra - primeiraletra;

            if (primeiraletra >= 0 && segundaletra >= 0 && diferencas >= 0)
            {
                Console.WriteLine("O numero de caracteres entre eles é:  " + diferencas);
            }
            else
            {
                Console.WriteLine("Erro!");
            }
            Console.ReadLine();
        }

        public static int contaletra(char ch, char[] letras)
        {

            int num = -1;
            for (int x = 0; x < letras.Length; x++)
            {
                if (letras[x] == ch)
                {
                    num = x;
                }
            }
            return num;
        }
    }
}
