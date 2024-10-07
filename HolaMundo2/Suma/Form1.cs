using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Suma.models;

namespace Suma
{
    public partial class Form1 : Form
    {
        //crear instancia del objeto

        Suma3 sumita = new Suma3();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //crear variables que contengan la información

            try
            {
                int numerito1 = Convert.ToInt32(tbnum1.Text);
                int numerito2 = Convert.ToInt16(tbnum2.Text);
                string result = sumita.Sumar(numerito1, numerito2);

                lblResultado.Text = $"El resultadod de la suma es {result}";

            }catch(Exception ex)
            {
                //primeor el message box show, depsues el exmessage, despues el mensaje de eroro, despues le ok  y despues el error
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
