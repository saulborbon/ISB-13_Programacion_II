using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3_MessageBox
{
    public partial class MessageBox : Form
    {
        public MessageBox()
        {
            InitializeComponent();
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = System.Windows.Forms.MessageBox.Show("¿Desea continuar?",
                                        "Confirmación",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                System.Windows.Forms.MessageBox.Show("Ha seleccionado SI");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Ha seleccionado NO.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = System.Windows.Forms.MessageBox.Show("¿Desea cerrar la aplicación?",
                                        "Confirmación",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);

    if (respuesta == DialogResult.Yes)
    {
        this.Close();
    }
}

        private void btnConectar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = System.Windows.Forms.MessageBox.Show("Error de conexión ¿Desea reintentar?",
                                        "Confirmación",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Error);
            if (resultado == DialogResult.Retry)
                System.Windows.Forms.MessageBox.Show("Reintentando conexión...");
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            int opcion = Convert.ToInt32(txtOpcion.Text);

            switch (opcion)
            {
                case 1:
                    System.Windows.Forms.MessageBox.Show("Opción 1 seleccionada", "Opción 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    System.Windows.Forms.MessageBox.Show("Opción 2 seleccionada", "Opción 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    System.Windows.Forms.MessageBox.Show("Opción 3 seleccionada", "Opción 3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Opción no válida", "Opción no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
