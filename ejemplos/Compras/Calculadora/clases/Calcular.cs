using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.clases
{
    internal class Calcular
    {


        public double Numero1 { get; set; }

        public double Numero2 { get; set; }


        public const double Pi = 3.1415;

        public double Area { get; set; }

        public double Radio {  get; set; }

        public double raizCuadrada()
        {
            return Math.Sqrt(Numero1);
        }

        public double numeroCubo()
        {
            return Math.Pow(this.Numero2, 3);
        }

        public double areaCirculo()
        {
            return Area = Pi * Math.Pow(this.Radio, 2);
        }
        

        //constructor

        public Calcular()
        {

        }


    }
}
