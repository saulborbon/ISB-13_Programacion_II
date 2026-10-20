using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO.Ejemplos
{
    public partial class fmrValidadores : Form
    {
        public fmrValidadores()
        {
            InitializeComponent();
        }

        private void fmrValidadores_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool todoBien = true;

            //validar nombre
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre no puede estar vacio.");
                todoBien = false;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }

            //validar edad
            int Edad;
            if (!int.TryParse(txtEdad.Text, out Edad) || Edad < 0)
            {
                errorProvider1.SetError(txtEdad, "Edad inválida.");
                todoBien = false;
            }
            else
            {
                errorProvider1.SetError(txtEdad, "");
            }

            //validar correo
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtCorreo.Text, pattern))
            {
                errorProvider1.SetError(txtCorreo, "El correo no es valido.");
                todoBien = false;
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }

            if (todoBien)
            {
                MessageBox.Show("Datos guardados correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, corrija los errores antes de guardar.");
            }
        }
    }
}
