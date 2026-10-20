using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad4_POO.Ejemplos;

namespace Unidad4_POO
{
    public partial class fmrPersona : Form
    {
        public fmrPersona()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona PersonaUno = new Persona();

            PersonaUno.Nombre = "Juan";
            PersonaUno.Edad = 30;

            PersonaUno.MostrarDatos();

            PersonaUno.Nombre = "María";
            PersonaUno.Edad = 25;

            PersonaUno.MostrarDatos();
        }
    }
}
