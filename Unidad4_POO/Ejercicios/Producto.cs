using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad4_POO.Ejercicios
{
    internal class Producto
    {
        private string nombre;
        private decimal precio;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string MostrarInfo()
        {
            return "Producto: " + Nombre + " - Precio: ₡" + Precio;
        }
    }
}
