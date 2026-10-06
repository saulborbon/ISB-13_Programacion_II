using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad1_Controles
{
    public partial class lbl_Bienvenida : Form
    {
        public lbl_Bienvenida()
        {
            InitializeComponent();
        }

        private void lblbienvenida_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBoton1_Click(object sender, EventArgs e)
        {
            Saludar();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Saludar()
        {
            string nombre = textBox1.Text;
            MessageBox.Show("Hola " + nombre + ", bienvenido al curso de C#");
        }

        private void lbl_Bienvenida_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario cargado correctamente.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
