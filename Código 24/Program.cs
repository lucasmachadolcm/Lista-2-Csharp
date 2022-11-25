using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0;
            double n2 = 0;
            int op = 0;
            double mult1 = 0;
            double mult2 = 0;
            double med = 0;
            double pares1 = 0;
            double pares2 = 0;
            
            do
            {
                Console.WriteLine("Digite o primeiro número");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                n2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o que se deseja fazer");
                Console.WriteLine("1 - Para verificar se são múltiplos");
                Console.WriteLine("2 - Para verificar se são pares");
                Console.WriteLine("3 - Para verificar se a média é maior que 7");
                Console.WriteLine("4 - Para sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:

                        mult1 = n1 / n2;
                        mult2 = n2 / n1;
                        if (mult1 == 0)
                        {
                            Console.WriteLine("O número " + n1 + " é múltiplo de " + n2);
                        }
                        else
                        {
                            Console.WriteLine("O número " + n1 + " não é múltiplo de " + n2);
                        }
                        if (mult2 == 0)
                        {
                            Console.WriteLine("O número " + n2 + " é múltiplo de " + n1);
                        }
                        else
                        {
                            Console.WriteLine("O número " + n2 + " não é múltiplo de " + n1);
                        }
                        Console.ReadLine();
                        break;

                    case 2:

                        pares1 = n1 / 2;
                        pares2 = n2 / 2;
                        if (pares1 == 0)
                        {
                            Console.WriteLine("O número " + n1 + " é par");
                        }
                        else
                        {
                            Console.WriteLine("O número " + n1 + " é impar");
                        }
                        if (mult2 == 0)
                        {
                            Console.WriteLine("O número " + n2 + " é par");
                        }
                        else
                        {
                            Console.WriteLine("O número " + n2 + " é impar");
                        }

                        break;

                    case 3:

                        med = (n1 + n2) / 2;
                        if (med >= 7)
                        {
                            Console.WriteLine("A média é: " + med);
                        }
                        else
                        {
                            Console.WriteLine("A médio é: " + med);
                        }
                        break;
                }
            } while (op != 4);
            Console.ReadLine();
        }
    }
}
