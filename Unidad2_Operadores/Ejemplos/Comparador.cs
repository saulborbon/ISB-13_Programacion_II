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
    public partial class Comparador : Form
    {
        public Comparador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(txtNum1.Text);
            int Num2 = int.Parse(txtNum2.Text);

            if (Num1 > Num2)
            {
                MessageBox.Show("El primer número es mayor.");
            }
            else if (Num1 < Num2)
            {
                MessageBox.Show("El segundo número es mayor.");
            }
            else
            {
                MessageBox.Show("Ambos números son iguales.");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Comparador_Load(object sender, EventArgs e)
        {

        }
    }
}
