using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoTienda.Presentador
{
    public interface IView
    {
        void MostrarDatosTienda(string nombre, string direccion);
        void MostrarDatosVendedor(string nombre, string apellido, string codVendedor);
        void MostrarCotizacion(float result);
        void MostrarMensajeExcedeStock();
        void consultarStock();
        string ImprimirCotizaciones();

        void AbrirForMulario();
    }
}
