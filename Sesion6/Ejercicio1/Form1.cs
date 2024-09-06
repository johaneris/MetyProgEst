using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            agregar();
            
        }

        public void agregar()
        {
            string nombre = tbNombre.Text.Trim(); //borra espacios al inicio y al final
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("no puede quedar vacio el nombre");
                tbNombre = null;
                return;

            }
            cmbNombres.Items.Add(nombre);
            tbNombre.Text = "";
            tbNombre.Focus();

        }

        private void cmdNombres2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cant = cmdNombres2.Items.Count;
            for(int i = 0; i <cant; i++)
            {
                string nombre = cmbNombres.Items[i].ToString();
                cmdNombres2.Items.Add(nombre);
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {

        }

        //public bool validarCampo(TextBox tb)
        //{
        //    if (tb.Text.Length == 0) return true;
        //    return false;

        //}

        //public bool Validar(string texto)
        //{
        //    if (texto.Length == 0) return true;
        //    return false;

        //}
    }
}
