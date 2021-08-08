using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoTienda.Modelo
{
    class Tienda
    {
        private string nombre;
        private string direccion;

        public Tienda(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public string Nombre { get => nombre; }
        public string Direccion { get => direccion; }
    }
}
