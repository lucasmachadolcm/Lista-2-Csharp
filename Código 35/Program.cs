﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            for (numero = 1; numero <= 100; numero++)
            {
                if (numero % 10 == 0)
                {
                    Console.WriteLine(numero + " -- multiplo de 10");
                }
                else
                {
                    Console.WriteLine(numero);
                }
            }
            Console.ReadLine();
        }
    }
}
