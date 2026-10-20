using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO.Ejercicios
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool formularioValido = true;

            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                errorProvider1.SetError(txtProducto, "Ingrese un producto válido.");
                formularioValido = false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precioValidado) || precioValidado <= 0)
            {
                errorProvider1.SetError(txtPrecio, "Ingrese un número válido.");
                formularioValido = false;
            }

            if (!formularioValido)
            {
                return;
            }



            Producto miProducto = new Producto();

            miProducto.Nombre = txtProducto.Text;

            miProducto.Precio = Convert.ToDecimal(txtPrecio.Text);

            MessageBox.Show(miProducto.MostrarInfo(), "Producto Guardado!.");
        }
    }
}
