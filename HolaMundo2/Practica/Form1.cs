using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica.models;

namespace Practica
{
    public partial class Form1 : Form
    {
        Hola holita = new Hola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            //basicamente enctiendo que se usa, el objeto y despues se interactua con el form
            //tipo

            holita.Name = tbNombre.Text;
            MessageBox.Show(holita.Saludar(Name));
        }
    }
}
