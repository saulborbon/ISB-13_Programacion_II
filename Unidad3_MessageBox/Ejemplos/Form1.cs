using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMessageBox = System.Windows.Forms.MessageBox;

namespace Unidad3_MessageBox
{
    public partial class frmEjemploSwitch : Form
    {
        public frmEjemploSwitch()
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

            switch (día)
            {
                case 1:
                    System.Windows.Forms.MessageBox.Show("Lunes"); break;
                case 2:
                    System.Windows.Forms.MessageBox.Show("Martes"); break;
                case 3:
                    System.Windows.Forms.MessageBox.Show("Miércoles"); break;
                case 4:
                    System.Windows.Forms.MessageBox.Show("Jueves"); break;
                case 5:
                    System.Windows.Forms.MessageBox.Show("Viernes"); break;
                case 6:
                    System.Windows.Forms.MessageBox.Show("Sábado"); break;
                case 7:
                    System.Windows.Forms.MessageBox.Show("Domingo"); break;
                default:
                    System.Windows.Forms.MessageBox.Show("Número de día inválido. Ingrese un número del 1 al 7."); break;
            }
        }
    }
}
