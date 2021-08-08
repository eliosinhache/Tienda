using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenIngresoTienda.Modelo;

namespace ExamenIngresoTienda.Presentador
{
    public class Cotizador
    {
        private IView vista;
        private Tienda tienda;
        private Vendedor vendedor;
        private List<Cotizacion> historialCotizaciones = new List<Cotizacion>();
        //private Cotizacion[] historialCot;
        private int codCotizacion = 0;
        private Pantalon pantalonesChupinesStandar;
        private Pantalon pantalonesChupinesPremium;
        private Pantalon pantalonesNormalesStandar;
        private Pantalon pantalonesNormalesPremium;
        private Camisa camisaManCortaConMaoStandar;
        private Camisa camisaManCortaConMaoPremium;
        private Camisa camisaManCortaNormalStandar;
        private Camisa camisaManCortaNormalPremium;
        private Camisa camisaManLargaConMaoStandar;
        private Camisa camisaManLargaConMaoPremium;
        private Camisa camisaManLargaNormalStandar;
        private Camisa camisaManLargaNormalPremium;
        public void IntanciarObjetos(IView vista)
        {
            this.vista = vista;
            tienda = new Tienda("MiTienda", "Av. Belgrano Sur 456");
            vendedor = new Vendedor("Elio", "Herrera", "001");
            vista.MostrarDatosTienda(tienda.Nombre, tienda.Direccion);
            vista.MostrarDatosVendedor(vendedor.Nombre, vendedor.Apellido, vendedor.CodVendedor);
            LlenarStockCamisas();
            LlenarStockPantalones();
        }
        private void LlenarStockPantalones()
        {
            pantalonesChupinesStandar = new Pantalon("chupines", "Standar", 500, 750);
            pantalonesChupinesPremium = new Pantalon("chupines", "Premium", 500, 750);
            pantalonesNormalesStandar = new Pantalon("normales", "Standar", 500, 250);
            pantalonesNormalesPremium = new Pantalon("normales", "Premium", 500, 250);
        }
        private void LlenarStockCamisas()
        {
            camisaManCortaConMaoStandar = new Camisa("Manga Corta", true, "Standar", 200, 100);
            camisaManCortaConMaoPremium = new Camisa("Manga Corta", true, "Premium", 200, 100);
            
            camisaManCortaNormalStandar = new Camisa("Manga Corta", false, "Standar", 200, 150);
            camisaManCortaNormalPremium = new Camisa("Manga Corta", false, "Premium", 200, 150);

            camisaManLargaConMaoStandar = new Camisa("Manga Larga", true, "Standar", 200, 75);
            camisaManLargaConMaoPremium = new Camisa("Manga Larga", true, "Premium", 200, 75);

            camisaManLargaNormalStandar = new Camisa("Manga Larga", false, "Standar", 200, 175);
            camisaManLargaNormalPremium = new Camisa("Manga Larga", false, "Premium", 200, 175);
        }

        public int consultarStock(bool mangaCorta, bool cuelloMao)
        {
            int stock = 0;
            if (mangaCorta)
            {
                if (cuelloMao)
                {
                    stock = stock + camisaManCortaConMaoStandar.Cantidad + camisaManCortaConMaoPremium.Cantidad;
                }
                else
                {
                    stock = stock + camisaManCortaNormalStandar.Cantidad + camisaManCortaNormalPremium.Cantidad;
                }
            }
            else
            {
                if (cuelloMao)
                {
                    stock = stock + camisaManLargaConMaoStandar.Cantidad + camisaManLargaConMaoPremium.Cantidad;
                }
                else
                {
                    stock = stock + camisaManLargaNormalStandar.Cantidad + camisaManLargaNormalPremium.Cantidad;
                }
            }
            return stock;
        }
        public int consultarStock(bool chupin)
        {
            if (chupin)
            {
                return pantalonesChupinesStandar.Cantidad + pantalonesChupinesPremium.Cantidad;
            }
            else
            {
                return pantalonesNormalesStandar.Cantidad + pantalonesNormalesPremium.Cantidad;
            }
        }
        public void Cotizar(bool mangaCorta, bool cuelloMao, float precioUnit, int cant)
        {
            float reb = 0;
            float aum = 0;
            float result;
            string camisa = "";
            if (cant <= consultarStock(mangaCorta, cuelloMao))
            {
                if (mangaCorta && cuelloMao)
                {
                    reb = (precioUnit * 10) / 100;
                    aum = (precioUnit * 3) / 100;
                    camisa = "Camisa manga corta con cuello mao";
                }
                else
                {
                    if (!mangaCorta && !cuelloMao)
                    {
                        camisa = "Camisa manga larga sin cuello mao";
                    }
                    if (mangaCorta)
                    {
                        reb = (precioUnit * 10) / 100;
                        camisa = "Camisa manga corta sin cuello mao";
                    }
                    if (cuelloMao)
                    {
                        aum = (precioUnit * 3) / 100;
                        camisa = camisa + "Camisa manga larga con cuello mao";
                    }
                }
                result = (precioUnit - reb + aum) * cant;
                guardarCotizacion(camisa, cant, result);
                vista.MostrarCotizacion(result);
                }
            else 
            {
                vista.MostrarMensajeExcedeStock();
            }
        }
        public void Cotizar(string calidad, bool chupin, float precioUnit, int cant)
        {
            float reb = 0;
            float aum = 0;
            string pantalon = "pantalon";
            float result;
            if (cant <= consultarStock(chupin))
            {
                if (calidad == "Premium")
                {
                    aum = (precioUnit * 30) / 100;

                    if (chupin)
                    {
                        reb = (precioUnit * 12) / 100;
                        pantalon = "Pantalon Chupin Premium";
                    }
                    else
                    { pantalon = "Pantalon Comun Premium"; }
                }
                else
                {
                    if (chupin)
                    {
                        reb = (precioUnit * 12) / 100;
                        pantalon = "Pantalon Chupin Standar";
                    }
                    else
                    { pantalon = "Pantalon Comun Standar"; }
                }
                result = (precioUnit - reb + aum) * cant;
                guardarCotizacion(pantalon, cant, result);
                vista.MostrarCotizacion(result);
            }
            else
            {
                vista.MostrarMensajeExcedeStock();
            }
        }

        private void guardarCotizacion(string prenda, int cantidad, float resultado)
        {
            DateTime fechahora = DateTime.Now;
            Cotizacion regCotizacion = new Cotizacion(codCotizacion, fechahora, vendedor.CodVendedor, prenda, cantidad, resultado);
            historialCotizaciones.Add(regCotizacion);
            //historialCot[codCotizacion] = regCotizacion;
            //codCotizacion++;
        }

        public string ConsultarHistorial(IView vista)
        {
            //vistaHistorial = vista;
            this.vista = vista;
            int asd = historialCotizaciones.Count;
            string listado = "";
            for (int rec = 0; rec < historialCotizaciones.Count; rec++)
            {
                listado = listado + "\t Registro " + rec + ": " + historialCotizaciones[rec].CodVendedor + "  "
                        + "\t Prenda: " + historialCotizaciones[rec].PrendaCotizada + "  \t\t Cantidad: " + historialCotizaciones[rec].CantUniCotizada + "  "
                        + "\t Cotizacion Final: $" + historialCotizaciones[rec].ResultCotizacion + " Pesos. " +
                        "\n-----------------------------------------------------------------------------------------------------------------------------------------------------------\n";
            }
            //vistaHistorial.ImprimirCotizaciones(listado);
            return listado;
        }

    }
}
