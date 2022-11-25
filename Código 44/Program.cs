using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            string letra;
            int opcao;
            double celsius = 0;
            double fahrenheit = 0;
            double altura = 0;
            double peso = 0;

            do
            {
                do
                {
                    Console.WriteLine("Digite uma das opções:\n\t1 – Conversão de Graus Celsius em Graus Fahrenheit\n\t2 – Conversão de Graus Fahrenheit em Graus Celsius\n\t3 – Peso ideal do homem\n\t4 – Peso ideal da mulher\n\n");
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao < 1 || opcao > 4)
                    {
                        Console.WriteLine("Opção Errada.\n");
                    }
                } while (opcao < 1 || opcao > 4);


                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite a temperatura em °C: ");
                        celsius = double.Parse(Console.ReadLine());
                        fahrenheit = (celsius * 1.8) + 32;
                        Console.WriteLine("A temperatura convertida é: " + fahrenheit + "°F.\n");
                        break;
                    case 2:
                        Console.WriteLine("Digite a temperatura em °F: ");
                        fahrenheit = double.Parse(Console.ReadLine());
                        celsius = (fahrenheit - 32) / 1.8;
                        Console.WriteLine("A temperatura convertida é: " + celsius + "°C.\n");
                        break;
                    case 3:
                        Console.WriteLine("Digite a altura: ");
                        altura = double.Parse(Console.ReadLine());
                        peso = (72.7 * altura) - 58;
                        Console.WriteLine("Seu peso ideal é: " + peso + "kg");
                        break;
                    case 4:
                        Console.WriteLine("Digite a altura: ");
                        altura = double.Parse(Console.ReadLine());
                        peso = (62.1 * altura) - 44.7;
                        Console.WriteLine("Seu peso ideal é: " + peso + "kg");
                        break;
                    default:
                        Console.WriteLine("Opção Errada.\n");
                        break;
                }

                Console.WriteLine("\nDeseja encerrar o programa? (s/N) ");
                letra = Console.ReadLine();
                if (letra == "s" || letra == "S")
                {
                    continuar = false;
                }
            } while (continuar);
            Console.ReadLine();
        }
    }
}
