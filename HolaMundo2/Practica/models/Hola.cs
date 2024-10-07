using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.models
{
    internal class Hola


    {
        //comnstructor vacio
        public Hola() { }
        //supongo que esto es un atributo
        string name;

        //atributo con el metodo get y set, osea obtener y asignar
        public string Name { get; set; }

        public string Saludar(string nombre)
        {
            this.Name = nombre;
            return $" hola vv, sos la mejor, {nombre} vamos por guaro";
        }
    }
}
