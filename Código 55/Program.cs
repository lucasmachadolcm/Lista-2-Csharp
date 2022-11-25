using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string NovaFrase = "";
            int x = 0;

            do
            {
                Console.WriteLine("Digite sua frase (até 50 characteres) :");
                frase = Console.ReadLine();
            } while (frase.Length > 50);

            string[] ArrayChars = new string[50];

            for (x = 0; x < ArrayChars.Length; x++)
            {
                if (ArrayChars[x] != "")
                {
                    NovaFrase = NovaFrase + ArrayChars[x];
                }
            }
            Console.WriteLine("Nova frase: " + NovaFrase);
            Console.ReadLine();
        }
    }
    
}
