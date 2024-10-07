using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace profe1.models
{
    internal class Operaciones
    {

        //primera funcion
        //solo hace un atarea, va a sumar 

        public double Suma(double a, double b)
        {
            return a + b;

        }

        public double Resta(double a, double b)
        {
            return a - b;
        }

        public double Multiplicacion(double a, double b)
        {
            return a * b;
        }

        public double Division(double a, double b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ewrror vv");
            }

            return 0;

        }

        public double RaizCuadrada(double a)
        {
            return Math.Sqrt(a);
        }

        public double Potencia(double a, double b)
        {

            //b es el exponente
            return Math.Pow(a, b);

        }

        public string salir()
        {
            return "bye";
        }
    }
}
