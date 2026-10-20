using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO
{
    public partial class fmrErrorProvider : Form
    {
        public fmrErrorProvider()
        {
            InitializeComponent();
        }

        private void rrmErrorProvider_Load(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }


            //if (!int.TryParse(txtEdad.Text, out int edad) || edad < 0
            //    errorProvider1.SetError(txtEdad, "Edad inválida.");
            //else
            //    errorProvider1.SetError(txtEdad, "");
            
            
           
        }
    }
}
