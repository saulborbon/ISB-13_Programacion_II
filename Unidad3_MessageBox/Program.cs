using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad3_MessageBox.Ejercicios_Clase_III;

namespace Unidad3_MessageBox
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmEjemploSwitch());
            //Application.Run(new MessageBox());
            //Application.Run(new Ejercicio1());
            //Application.Run(new Ejercicio2());
            Application.Run(new Ejercicio3());
            
        }
    }
}
