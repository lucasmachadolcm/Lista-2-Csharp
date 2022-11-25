using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_33
{
    internal class Aluno
    {
        private String NumeroMatricula;
        private double NotaProva;

        public void setAluno(String NumeroMatricula, double NotaProva)
        {
            this.NumeroMatricula = NumeroMatricula;
            this.NotaProva = NotaProva;
        }

        public double getNotaProva()
        {
            return NotaProva;
        }

    }
}
