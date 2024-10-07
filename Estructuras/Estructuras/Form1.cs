using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras
{
    public partial class Form : System.Windows.Forms.Form
    {
         //primero hacer la struct
       struct Punto
        {
            //campos
            public int X { get; set; }  

            public int Y { get; set; }
            //contructor
            public Punto(int x, int y)
            {
                X = x;
                Y = y;
            }
            //crear los valores
            public String Mostrar()
            {
                return $" x = {X}, y = {Y}";
            }
        }
        
        //crear objetos 
        //arreglos
        const int MAx = 10;
        Punto[] puntos = new Punto[MAx];
        //iterador 
        
        int i = 0;
       
        public Form()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // crear objeto

            int x = int.Parse(tbX.Text);
            int y = int.Parse(tbY.Text);  

            
            Punto punto = new Punto();

            //al tener el objeto se pasa al arreglo

            if(i < MAx)
            {
                puntos[i] = punto;
                i++;
            }
            else
            {
                MessageBox.Show("No se puede agregar mas elementos.", "Puntos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowData();

            
        }

        private void ShowData()
        {
            //origen de datos
            dgvPuntos.DataSource = null;
            dgvPuntos.DataSource = puntos;
            dgvPuntos.Refresh();
        }

    }
}
