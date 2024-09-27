using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz.models
{
    internal class Matriz2
    {
        public int[,] matriz1 = new int[4, 4];
        public int[,] matriz2 = new int[4, 4];
        public int[,] sumaMatriz = new int[4, 4];

        // Método para sumar las dos matrices
        public void SumarMatrices()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumaMatriz[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
        }

        // Método para cargar los valores en las matrices
        public void CargarValores(int[] valoresMatriz1, int[] valoresMatriz2)
        {
            int contador = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz1[i, j] = valoresMatriz1[contador];
                    matriz2[i, j] = valoresMatriz2[contador];
                    contador++;
                }
            }
        }

        // Método para obtener la matriz de suma en formato de string
        public string MostrarSuma()
        {
            string resultado = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    resultado += sumaMatriz[i, j] + "\t";
                }
                resultado += "\n";
            }
            return resultado;
        }
    }
}
