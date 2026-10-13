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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Validar que el valor ingresado sea un número entero
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                //Validar que esté en el rango
                if (numero >= 1 && numero <= 4)
                {
                    //Evaluarsi el rango es correcto
                    switch (numero)
                    {
                        case 1:
                            System.Windows.Forms.MessageBox.Show("Has seleccionado la opción 1: Inicio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case 2:
                            System.Windows.Forms.MessageBox.Show("Has seleccionado la opción 2: Configuración.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case 3:
                            System.Windows.Forms.MessageBox.Show("Has seleccionado la opción 3: Reportes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case 4:
                            System.Windows.Forms.MessageBox.Show("Has seleccionado la opción 4: Ayuda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
                else
                {
                    // Mensaje de error si el número está fuera de rango
                    System.Windows.Forms.MessageBox.Show("Error: El número debe estar en el rango establecido.", "Error de Rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mensaje de error si el texto ingresado no es un número válido
                System.Windows.Forms.MessageBox.Show("Error: Por favor, ingrese un número entero válido.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
