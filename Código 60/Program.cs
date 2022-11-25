﻿using System;
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
            int x = 0;
            int y = 0;
            Console.WriteLine("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine(VerificaQuadrante(x, y));
            Console.ReadLine();
        }
        public static int VerificaQuadrante(int x, int y)
        {
            bool quadx, quady;
            if (x >= 0)
            {
                quadx = true;
            }
            else
            {
                quadx = false;
            }
            if (y >= 0)
            {
                quady = true;
            }
            else
            {
                quady = false;
            }
            if (x == 0 || y == 0) return 0;
            else if (quadx && quady) return 1;
            else if (!quadx && quady) return 2;
            else if (!quadx && !quady) return 3;
            else return 4;

        }

    }
}
    

