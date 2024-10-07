using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Tarea.models;

namespace Tarea.models
{
    internal class Registro
    {
        private RegstroSoftware[] listaSoftware;
        private int contador;

        public Registro()
        {
            listaSoftware = new RegstroSoftware[30]; 
            contador = 0;
        }

        // Método para agregar al software
        public void AgregarSoftware(RegstroSoftware software)
        {
            if (contador < 30)
            {
                listaSoftware[contador] = software;
                contador++;
            }
            else
            {
                throw new Exception("No se pueden agregar más registros, el arreglo está lleno.");
            }
        }

        // Método para eliminar software
        public void EliminarSoftware(int indice)
        {
            if (indice >= 0 && indice < contador)
            {
                for (int i = indice; i < contador - 1; i++)
                {
                    listaSoftware[i] = listaSoftware[i + 1];
                }
                listaSoftware[contador - 1] = null;
                contador--;
            }
            else
            {
                throw new Exception("fuera de rango.");
            }
        }

        // Método para actualizar software
        public void ActualizarSoftware(int indice, RegstroSoftware software)
        {
            if (indice >= 0 && indice < contador)
            {
                listaSoftware[indice] = software;
            }
            else
            {
                throw new Exception("Índice fuera de rango.");
            }
        }

        // Guardar la lista en un archivo binario
        public void GuardarEnDisco(string ruta)
        {
            FileStream archivo = new FileStream(ruta, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(archivo, listaSoftware);
            archivo.Close();
        }

        // Recuperar la lista del archivo binario
        public void RecuperarDeDisco(string ruta)
        {
            if (File.Exists(ruta))
            {
                FileStream archivo = new FileStream(ruta, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                listaSoftware = (RegstroSoftware[])formatter.Deserialize(archivo);
                archivo.Close();

                // Recalcular el contador
                contador = 0;
                foreach (RegstroSoftware software in listaSoftware)
                {
                    if (software != null)
                        contador++;
                    else
                        break;
                }
            }
            else
            {
                throw new Exception("Archivo no encontrado.");
            }
        }

        // Método para obtener todos los softwares
        public RegstroSoftware[] ObtenerTodos()
        {
            return listaSoftware;
        }
    }
}

