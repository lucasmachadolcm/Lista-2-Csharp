using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string vogais = "aeiouAEIOU";
            string StringVogais = "";
            int x = 0;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            char[] ArrayChars = frase.ToCharArray();

            for (x = 0; x < ArrayChars.Length; x++)
            {


                if (vogais.Contains("" + ArrayChars[x]))
                { // ""+Char - soma uma string "" com um charactere, transformando o caractere em string
                    StringVogais += ArrayChars[x];
                }
            }

            Console.WriteLine("As vogais da frase são: " + StringVogais);
            Console.ReadLine();
        }
    }
    
}
