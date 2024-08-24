using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcularnota.clases
{
    internal class Nota
    {

        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double calcularNota()
        {
            return (this.Nota1 + this.Nota2 + this.Nota3) / 3;
        }

        public Nota()
        {

        }


    }
}
