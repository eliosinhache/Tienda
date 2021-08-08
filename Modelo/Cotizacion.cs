using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoTienda.Modelo
{
    class Cotizacion
    {
        private int numIdentificacion;
        private DateTime fechaHoraCotizacion;
        private string codVendedor;
        private string prendaCotizada;
        private int cantUniCotizada;
        private float resultCotizacion;

        public Cotizacion(int numIdentificacion, DateTime fechaHora, string codVendedor, string prendaCotizada, int cantCotizada, float resultadoCotizacion) 
        {
            this.numIdentificacion = numIdentificacion;
            this.fechaHoraCotizacion = fechaHora;
            this.codVendedor = codVendedor;
            this.prendaCotizada = prendaCotizada;
            this.cantUniCotizada = cantCotizada;
            this.resultCotizacion = resultadoCotizacion;
        }

        public int NumIdentificacion { get => numIdentificacion;  }
        public DateTime FechaHoraCotizacion { get => fechaHoraCotizacion; }
        public string CodVendedor { get => codVendedor;  }
        public string PrendaCotizada { get => prendaCotizada; }
        public int CantUniCotizada { get => cantUniCotizada;  }
        public float ResultCotizacion { get => resultCotizacion;  }
    }
}
