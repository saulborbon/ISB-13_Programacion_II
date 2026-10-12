using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Unidad2_C_
{
    public partial class lblDos : Form
    {
        public lblDos()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            // Validamos que ambos cuadros de texto tengan números válidos
            if (double.TryParse(txtUno.Text, out double num1) &&
                double.TryParse(txtDos.Text, out double num2))
            {
                if (num1 > num2)
                {
                    MessageBox.Show($"El número mayor es: {num1}", "Resultado");
                }
                else if (num2 > num1)
                {
                    MessageBox.Show($"El número mayor es: {num2}", "Resultado");
                }
                else
                {
                    MessageBox.Show("Ambos números son iguales.", "Resultado");
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce números válidos en ambos campos.", "Error");
            }

        }

        private void lblDos_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rojo");
            listBox1.Items.Add("Verde");
            listBox1.Items.Add("Azul");

            this.ContextMenuStrip = contextMenuStrip1;
        }

        private void cambiarColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cuadroColor = new ColorDialog())
            {
                if (cuadroColor.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = cuadroColor.Color; 
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string color = listBox1.SelectedItem.ToString();

                if (color == "Rojo") this.BackColor = Color.LightCoral;
                else if (color == "Verde") this.BackColor = Color.LightGreen;
                else if (color == "Azul") this.BackColor = Color.LightBlue;
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
