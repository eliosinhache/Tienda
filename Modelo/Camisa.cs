using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoTienda.Modelo
{
    class Camisa : Prenda
    {
        private int codCamisa;
        private string tipoManga;
        private bool cuelloMao;
        public Camisa(string tipoManga, bool cuelloMao, string calidad, float precio, int cantidad )
        {
            this.tipoManga = tipoManga;
            this.cuelloMao = cuelloMao;
            this.Calidad = calidad;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }
    }
}
