using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma.models
{
    internal class Suma3
    {
        //contructor

        public Suma3() { }

        //atributos 

        private int num1;
        private int num2;
        private int resultado;

        //la propiedad con el metodo get y set

        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Resultado { get; set; }  


        //metodo, no es necesario pasar el resultado como un fucking parametro

        public string Sumar(int numero1, int numero2)
        {
            try
            {
                resultado = numero1 + numero2;
            }catch (Exception ex)
            {
                return "ERROR" + ex.Message;
            }

            return $"el resultado es: {resultado}";
        }

    }
}
