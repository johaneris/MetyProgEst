using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intento2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {

            mostrarNota();


        }

        private void mostrarNota()
        {
            int calificacion;

            // Validar que la calificación ingresada sea un número entero
            if (int.TryParse(tbCalificacion.Text, out calificacion))
            {
                // Verificar que la calificación esté en el rango 0 a 100
                if (calificacion >= 0 && calificacion <= 100)
                {
                    // String para almacenar la letra de la calificación
                    string letraCalificacion = "";

                    // Asignar la letra según la calificación
                    if (calificacion >= 90)
                        letraCalificacion = "A";
                    else if (calificacion >= 80)
                        letraCalificacion = "B";
                    else if (calificacion >= 70)
                        letraCalificacion = "C";
                    else if (calificacion >= 60)
                        letraCalificacion = "D";
                    else
                        letraCalificacion = "F";

                    // Mostrar el resultado en un Label (nombre del estudiante + calificación en letra)
                    lblResultado.Text = $"{tbNombre.Text} tiene una calificación de {letraCalificacion}.";
                }
                else
                {
                    // Mostrar mensaje de error si la calificación no está en el rango 0-100
                    MessageBox.Show("Por favor ingrese una calificación entre 0 y 100.");
                }
            }
            else
            {
                // Mostrar mensaje de error si no se ingresa un número válido
                MessageBox.Show("Por favor ingrese un número válido para la calificación.");
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
