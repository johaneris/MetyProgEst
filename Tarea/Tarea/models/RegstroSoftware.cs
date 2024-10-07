using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.models
{
    public class RegstroSoftware
    {
       
            public string Fabricante { get; set; }
            public string Nombre { get; set; }
            public string Edicion { get; set; }
            public string Version { get; set; }
            public string Licenciamiento { get; set; }
            public string Descripcion { get; set; }

            // Constructor
            public RegstroSoftware(string fabricante, string nombre, string edicion, string version, string licenciamiento, string descripcion)
            {
                Fabricante = fabricante;
                Nombre = nombre;
                Edicion = edicion;
                Version = version;
                Licenciamiento = licenciamiento;
                Descripcion = descripcion;
            }
        }
    }

