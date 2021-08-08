using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenIngresoTienda.Presentador;

namespace ExamenIngresoTienda.Vista
{
    public partial class ImpresionHistorial : Form
    {
        private IView form1;
        public ImpresionHistorial(IView vistaForm1)
        {
            this.form1 = vistaForm1;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ImpresionHistorial_Load(object sender, EventArgs e)
        {
            lblHistorialDeCotizaciones.Text = form1.ImprimirCotizaciones();
        }

        public void ImprimirCotizaciones(string historial)
        {
            lblHistorialDeCotizaciones.Text = historial;
        }

        private void ImpresionHistorial_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.AbrirForMulario();
        }
    }
}
