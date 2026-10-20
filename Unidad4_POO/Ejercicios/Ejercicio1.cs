using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO.Ejercicios
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            Producto miProducto = new Producto();

            miProducto.Nombre = "GameBoy Advance";
            miProducto.Precio = 60.000m;

            MessageBox.Show(miProducto.MostrarInfo());
        }
    }
}
