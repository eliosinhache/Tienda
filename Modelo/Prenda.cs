using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoTienda.Modelo
{
    abstract class Prenda
    {
        private string calidad;
        private float precio;
        private int cantidad;

        public string Calidad { get => calidad; set => calidad = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
