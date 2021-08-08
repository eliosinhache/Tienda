using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoTienda.Modelo
{
    class Vendedor
    {
        private string codVendedor;
        private string nombre;
        private string apellido;

        public Vendedor(string nombre, string apellido, string codVendedor)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codVendedor = codVendedor;
        }

        public string CodVendedor { get => codVendedor;  }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
    }
}
