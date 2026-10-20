using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad4_POO.Ejemplos;
using Unidad4_POO.Ejercicios;

namespace Unidad4_POO
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
           //Application.Run(new fmrPersona());
           //Application.Run(new fmrErrorProvider());
           //Application.Run(new fmrValidadores());
           //Application.Run(new Ejercicio1());
            Application.Run(new Ejercicio2());
        }
        

    }
}
