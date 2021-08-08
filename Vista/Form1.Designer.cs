
namespace ExamenIngresoTienda
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTiendaNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVendedorNomApeCod = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxCantidad = new System.Windows.Forms.TextBox();
            this.txtboxPrecioUnitario = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radbtnPremium = new System.Windows.Forms.RadioButton();
            this.radbtnStandar = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblStockDisponible = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkChupin = new System.Windows.Forms.CheckBox();
            this.cehckCuelloMao = new System.Windows.Forms.CheckBox();
            this.checkMangaCorta = new System.Windows.Forms.CheckBox();
            this.radbtnPantalon = new System.Windows.Forms.RadioButton();
            this.radbtnCamisa = new System.Windows.Forms.RadioButton();
            this.lblTiendaDireccion = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblCotizacionFinal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTiendaNombre
            // 
            this.lblTiendaNombre.AutoSize = true;
            this.lblTiendaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiendaNombre.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblTiendaNombre.Location = new System.Drawing.Point(17, 92);
            this.lblTiendaNombre.Name = "lblTiendaNombre";
            this.lblTiendaNombre.Size = new System.Drawing.Size(208, 24);
            this.lblTiendaNombre.TabIndex = 0;
            this.lblTiendaNombre.Text = "Nombre de la Tienda";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.lblVendedorNomApeCod);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(-6, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 459);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblVendedorNomApeCod
            // 
            this.lblVendedorNomApeCod.AutoSize = true;
            this.lblVendedorNomApeCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorNomApeCod.Location = new System.Drawing.Point(18, 29);
            this.lblVendedorNomApeCod.Name = "lblVendedorNomApeCod";
            this.lblVendedorNomApeCod.Size = new System.Drawing.Size(327, 16);
            this.lblVendedorNomApeCod.TabIndex = 4;
            this.lblVendedorNomApeCod.Text = "Nombre y Apellido del Vendedor | Codigo del Vendor";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(442, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 16);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Historial de Cotizaciones";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.linkLabel1_MouseDown);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txtboxCantidad);
            this.groupBox6.Controls.Add(this.txtboxPrecioUnitario);
            this.groupBox6.Location = new System.Drawing.Point(251, 246);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(347, 74);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Precio Unitario y Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "$";
            // 
            // txtboxCantidad
            // 
            this.txtboxCantidad.Location = new System.Drawing.Point(212, 33);
            this.txtboxCantidad.Name = "txtboxCantidad";
            this.txtboxCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtboxCantidad.TabIndex = 1;
            // 
            // txtboxPrecioUnitario
            // 
            this.txtboxPrecioUnitario.Location = new System.Drawing.Point(37, 31);
            this.txtboxPrecioUnitario.Name = "txtboxPrecioUnitario";
            this.txtboxPrecioUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtboxPrecioUnitario.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radbtnPremium);
            this.groupBox5.Controls.Add(this.radbtnStandar);
            this.groupBox5.Location = new System.Drawing.Point(18, 246);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(227, 74);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Calidad de Prenda";
            // 
            // radbtnPremium
            // 
            this.radbtnPremium.AutoSize = true;
            this.radbtnPremium.Location = new System.Drawing.Point(115, 33);
            this.radbtnPremium.Name = "radbtnPremium";
            this.radbtnPremium.Size = new System.Drawing.Size(65, 17);
            this.radbtnPremium.TabIndex = 6;
            this.radbtnPremium.TabStop = true;
            this.radbtnPremium.Text = "Premium";
            this.radbtnPremium.UseVisualStyleBackColor = true;
            // 
            // radbtnStandar
            // 
            this.radbtnStandar.AutoSize = true;
            this.radbtnStandar.Location = new System.Drawing.Point(22, 32);
            this.radbtnStandar.Name = "radbtnStandar";
            this.radbtnStandar.Size = new System.Drawing.Size(62, 17);
            this.radbtnStandar.TabIndex = 5;
            this.radbtnStandar.TabStop = true;
            this.radbtnStandar.Text = "Standar";
            this.radbtnStandar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblStockDisponible);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(12, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(580, 53);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // lblStockDisponible
            // 
            this.lblStockDisponible.AutoSize = true;
            this.lblStockDisponible.Location = new System.Drawing.Point(191, 25);
            this.lblStockDisponible.Name = "lblStockDisponible";
            this.lblStockDisponible.Size = new System.Drawing.Size(139, 13);
            this.lblStockDisponible.TabIndex = 5;
            this.lblStockDisponible.Text = "______________________";
            this.lblStockDisponible.Click += new System.EventHandler(this.lblStockDisponible_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unidades de Stock Disponibles:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.checkChupin);
            this.groupBox3.Controls.Add(this.cehckCuelloMao);
            this.groupBox3.Controls.Add(this.checkMangaCorta);
            this.groupBox3.Controls.Add(this.radbtnPantalon);
            this.groupBox3.Controls.Add(this.radbtnCamisa);
            this.groupBox3.Location = new System.Drawing.Point(12, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 105);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prenda";
            // 
            // checkChupin
            // 
            this.checkChupin.AutoSize = true;
            this.checkChupin.Location = new System.Drawing.Point(194, 75);
            this.checkChupin.Name = "checkChupin";
            this.checkChupin.Size = new System.Drawing.Size(59, 17);
            this.checkChupin.TabIndex = 4;
            this.checkChupin.Text = "Chupin";
            this.checkChupin.UseVisualStyleBackColor = true;
            this.checkChupin.CheckedChanged += new System.EventHandler(this.checkMangaCorta_CheckedChanged);
            // 
            // cehckCuelloMao
            // 
            this.cehckCuelloMao.AutoSize = true;
            this.cehckCuelloMao.Location = new System.Drawing.Point(302, 26);
            this.cehckCuelloMao.Name = "cehckCuelloMao";
            this.cehckCuelloMao.Size = new System.Drawing.Size(79, 17);
            this.cehckCuelloMao.TabIndex = 3;
            this.cehckCuelloMao.Text = "Cuello Mao";
            this.cehckCuelloMao.UseVisualStyleBackColor = true;
            this.cehckCuelloMao.CheckedChanged += new System.EventHandler(this.checkMangaCorta_CheckedChanged);
            // 
            // checkMangaCorta
            // 
            this.checkMangaCorta.AutoSize = true;
            this.checkMangaCorta.Location = new System.Drawing.Point(194, 26);
            this.checkMangaCorta.Name = "checkMangaCorta";
            this.checkMangaCorta.Size = new System.Drawing.Size(87, 17);
            this.checkMangaCorta.TabIndex = 2;
            this.checkMangaCorta.Text = "Manga Corta";
            this.checkMangaCorta.UseVisualStyleBackColor = true;
            this.checkMangaCorta.CheckedChanged += new System.EventHandler(this.checkMangaCorta_CheckedChanged);
            // 
            // radbtnPantalon
            // 
            this.radbtnPantalon.AutoSize = true;
            this.radbtnPantalon.Location = new System.Drawing.Point(22, 75);
            this.radbtnPantalon.Name = "radbtnPantalon";
            this.radbtnPantalon.Size = new System.Drawing.Size(67, 17);
            this.radbtnPantalon.TabIndex = 1;
            this.radbtnPantalon.Text = "Pantalon";
            this.radbtnPantalon.UseVisualStyleBackColor = true;
            this.radbtnPantalon.CheckedChanged += new System.EventHandler(this.radbtnPantalon_CheckedChanged);
            // 
            // radbtnCamisa
            // 
            this.radbtnCamisa.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.radbtnCamisa.Location = new System.Drawing.Point(22, 18);
            this.radbtnCamisa.Name = "radbtnCamisa";
            this.radbtnCamisa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radbtnCamisa.Size = new System.Drawing.Size(76, 31);
            this.radbtnCamisa.TabIndex = 0;
            this.radbtnCamisa.Text = "Camisa";
            this.radbtnCamisa.UseVisualStyleBackColor = true;
            this.radbtnCamisa.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblTiendaDireccion
            // 
            this.lblTiendaDireccion.AutoSize = true;
            this.lblTiendaDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiendaDireccion.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblTiendaDireccion.Location = new System.Drawing.Point(370, 92);
            this.lblTiendaDireccion.Name = "lblTiendaDireccion";
            this.lblTiendaDireccion.Size = new System.Drawing.Size(222, 24);
            this.lblTiendaDireccion.TabIndex = 3;
            this.lblTiendaDireccion.Text = "Direccion de la Tienda";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblCotizacionFinal);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Location = new System.Drawing.Point(18, 326);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(580, 72);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            // 
            // lblCotizacionFinal
            // 
            this.lblCotizacionFinal.AutoSize = true;
            this.lblCotizacionFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacionFinal.Location = new System.Drawing.Point(216, 35);
            this.lblCotizacionFinal.Name = "lblCotizacionFinal";
            this.lblCotizacionFinal.Size = new System.Drawing.Size(153, 24);
            this.lblCotizacionFinal.TabIndex = 6;
            this.lblCotizacionFinal.Text = "_____________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "$";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrchid;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cotizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(162, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(295, 37);
            this.label10.TabIndex = 5;
            this.label10.Text = "Cotizador Express";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 75);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-9, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(583, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "_________________________________________________________________________________" +
    "_________________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(511, 404);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 27);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(602, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblTiendaDireccion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblTiendaNombre);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTiendaNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVendedorNomApeCod;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radbtnPantalon;
        private System.Windows.Forms.RadioButton radbtnCamisa;
        private System.Windows.Forms.Label lblTiendaDireccion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkChupin;
        private System.Windows.Forms.CheckBox cehckCuelloMao;
        private System.Windows.Forms.CheckBox checkMangaCorta;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxCantidad;
        private System.Windows.Forms.TextBox txtboxPrecioUnitario;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radbtnPremium;
        private System.Windows.Forms.RadioButton radbtnStandar;
        private System.Windows.Forms.Label lblStockDisponible;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblCotizacionFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}

