using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3_MessageBox.Ejercicios_Clase_III
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int opcion;

            if (int.TryParse(txtOpcion.Text, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        System.Windows.Forms.MessageBox.Show("Seleccionaste la opción 1");
                        break;

                    case 2:
                        System.Windows.Forms.MessageBox.Show("Seleccionaste la opción 2");
                        break;

                    case 3:
                        System.Windows.Forms.MessageBox.Show("Seleccionaste la opción 3");
                        break;

                    default:
                        System.Windows.Forms.MessageBox.Show("Opción no válida. Ingrese 1, 2 o 3.");
                        break;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }
    }
}
