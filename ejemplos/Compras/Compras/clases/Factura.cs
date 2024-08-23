using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Compras.clases
{
    internal class Factura
    {
        public string Producto {  get; set; } // producto es el atributo, son como caracteristicas y get set son los metodos
        public double Precio { get; set; } //get obtiene el valor y set lo asigna, metodos, hay atributos natos vv 
        public int Cantidad { get; set; }
        public double calcularMonto() //sin parametros :0
        {
            return this.Precio * this.Cantidad;
        }

        //contructor es la forma en la que creamos nuevos objetos, facilita la creacion de nuevos objetos 
        public Factura()
        {

        }

    }
}
