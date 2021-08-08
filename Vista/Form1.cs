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

namespace ExamenIngresoTienda
{
    public partial class Form1 : Form, IView
    {
        public Cotizador cotizadorObj = new Cotizador();
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radBtnsCambiaron();
        }
        private bool ValidarEntrada()
        {
            try
            {
                int.Parse(txtboxCantidad.Text);
                float.Parse(txtboxPrecioUnitario.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Cantidad y Precio deben ser enteros y decimal respectivamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // manda la vista para la cotizacion
            if (ValidarEntrada()) {
                if (radbtnCamisa.Checked == true)
                {
                    cotizadorObj.Cotizar(checkMangaCorta.Checked, cehckCuelloMao.Checked, float.Parse(txtboxPrecioUnitario.Text), int.Parse(txtboxCantidad.Text));
                }
                else
                {
                    if (radbtnStandar.Checked == true)
                    { cotizadorObj.Cotizar("Standar", checkChupin.Checked, float.Parse(txtboxPrecioUnitario.Text), int.Parse(txtboxCantidad.Text)); }
                    else
                    { cotizadorObj.Cotizar("Premium", checkChupin.Checked, float.Parse(txtboxPrecioUnitario.Text), int.Parse(txtboxCantidad.Text));  }
                }
            }
        }

        public void MostrarDatosTienda(string nombre, string direccion)
        {
            lblTiendaNombre.Text = nombre;
            lblTiendaDireccion.Text = direccion;
        }

        public void MostrarDatosVendedor(string nombre, string apellido, string codVendedor)
        {
            lblVendedorNomApeCod.Text = nombre + " " + apellido + " | CodVendedor: " + codVendedor;
        }

        public void MostrarCotizacion(float result)
        {
            lblCotizacionFinal.Text = result.ToString() + " Pesos";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cotizadorObj.IntanciarObjetos(this);
            radbtnCamisa.Checked = true;
            radbtnStandar.Checked = true;
        }

        private void radbtnPantalon_CheckedChanged(object sender, EventArgs e)
        {
            radBtnsCambiaron();
        }

        private void radBtnsCambiaron()
        {
            if (radbtnCamisa.Checked == true)
            {
                checkMangaCorta.Enabled = true;
                cehckCuelloMao.Enabled = true;
                checkChupin.Enabled = false;
            }
            else
            {
                checkMangaCorta.Enabled = false;
                cehckCuelloMao.Enabled = false;
                checkChupin.Enabled = true;
            }
            consultarStock();
        }

        public void consultarStock()
        {
            if (radbtnCamisa.Checked == true)
            {
                lblStockDisponible.Text = cotizadorObj.consultarStock(checkMangaCorta.Checked, cehckCuelloMao.Checked).ToString();
            }
            else
            {
                lblStockDisponible.Text = cotizadorObj.consultarStock(checkChupin.Checked).ToString();
            }
        }

        private void checkMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            consultarStock();
        }

        private void linkLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            Vista.ImpresionHistorial formImpresiones = new Vista.ImpresionHistorial(this);
            formImpresiones.Show();
            this.Hide();
        }

        void IView.MostrarMensajeExcedeStock()
        {
            MessageBox.Show("La cantidad Excede el stock disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public string ImprimirCotizaciones()
        {
            return cotizadorObj.ConsultarHistorial(this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblStockDisponible_Click(object sender, EventArgs e)
        {

        }

        public void AbrirForMulario()
        {
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
