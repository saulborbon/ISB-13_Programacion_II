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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int día;
            día = Convert.ToInt32(txtDiaDeLaSemana.Text);
      
            switch (día)             {
                    case 1:
                        MessageBox.Show("Lunes");break;
                    case 2:
                        MessageBox.Show("Martes");break;
                    case 3:
                        MessageBox.Show("Miércoles");break;
                    case 4:
                        MessageBox.Show("Jueves");break;
                    case 5:
                        MessageBox.Show("Viernes");break;
                    case 6:
                        MessageBox.Show("Sábado");break;
                    case 7:
                        MessageBox.Show("Domingo");break;
                    default:
                        MessageBox.Show("Número de día inválido. Ingrese un número del 1 al 7.");break;
                }
        }
    }
}
