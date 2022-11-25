using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade = 0;
            bool parar = false;
            string letra;
            string categoria;

            do
            {
                do
                {
                    Console.WriteLine("Digite a idade do nadador: ");
                    idade = double.Parse(Console.ReadLine());
                    if (idade < 5)
                    {
                        Console.WriteLine("Idade inválida.");
                    }
                } while (idade < 5);

                Console.WriteLine();

                if (idade >= 5 && idade < 7)
			{
                    categoria = "Infantil A";
            }

            else if (idade >= 8 && idade < 12)
                {
                    categoria = "Infantil B";
                }
                else if (idade >= 12 && idade < 14)
                {
                    categoria = "Juvenil A";
                }
                else if (idade >= 14 && idade < 17)
			    {
                    categoria = "Juvenil B";
                }

            else
                {
                    categoria = "Adultos";
                }


                Console.WriteLine("A categoria é: " + categoria);

                Console.WriteLine("\nDeseja encerrar o programa? (s/N) ");
                letra = Console.ReadLine();
                if (letra == "s" || letra == "S")
                {
                    parar = true;
                }

            } while (parar == false);
            Console.ReadLine();
        }
    }
}
