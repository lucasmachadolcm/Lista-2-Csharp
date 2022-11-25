using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempo = 0;
            double velocidade = 0;
            double distancia = 0;
            double litros = 0;
            Console.WriteLine("Digite o tempo da viagem: ");
            tempo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade média durante a viagem: ");
            velocidade = double.Parse(Console.ReadLine());
            distancia = tempo * velocidade;
            litros = distancia / 12;
            Console.WriteLine("A velocidade média foi: " + velocidade + " KM/H");
            Console.WriteLine("O tempo gasto foi: " + tempo + " Horas");
            Console.WriteLine("A distancia percorrida foi: " + distancia + " KM");
            Console.WriteLine("Foram gastos de combustivel " + litros + " litros");
            Console.ReadLine();
        }
    }
}
