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
    public partial class EjemplosControles : Form
    {
        public EjemplosControles()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EjemplosControles_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rojo");
            listBox1.Items.Add("Verde");
            listBox1.Items.Add("Azul");

            listBox1.BackColor = Color.LightBlue;
            this.BackColor = Color.LightGray;
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            listBox1.Items.Add("Se seleccionó el color ROJO");
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            listBox1.Items.Add("Se seleccionó el color AZUL");
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            listBox1.Items.Add("Se seleccionó el color VERDE");
        }
    }
}
