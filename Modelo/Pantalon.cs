using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoTienda.Modelo
{
    class Pantalon : Prenda
    {
        private string tipoPantalon;
        public Pantalon(string tipoPantalon, string calidad, float precio, int cantidad)
        {
            this.tipoPantalon = tipoPantalon;
            this.Calidad = calidad;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }
    }
}
