using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad2_Operadores.Ejemplos
{
    public partial class EjemploOperadores : Form
    {
        public EjemploOperadores()
        {
            InitializeComponent();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            int a = 10;
            int b = 5;

            bool resultado = a > b; // Operador relacional

            int suma = a + b; // Operador aritmético
            int modulo = a % b; // Operador aritmético

            bool condicion = (a > b) && (b > 0); // Operador lógico

            MessageBox.Show("¿a es mayor que b? " + resultado);
            MessageBox.Show("La suma de a y b es: " + suma);
            MessageBox.Show("El módulo de a y b es: " + modulo);
            MessageBox.Show("¿(a>b) y (b>0)? " + condicion);
        }
    }
}
