
namespace Ejercicio02_Cajas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvCajas = new System.Windows.Forms.ListView();
            this.btnAgregarCaja = new System.Windows.Forms.Button();
            this.txtNombreCajero = new System.Windows.Forms.TextBox();
            this.txtCodigoCaja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.txtMontoCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvCompras = new System.Windows.Forms.ListView();
            this.btnAgregarCompra = new System.Windows.Forms.Button();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbCodigoCompra = new System.Windows.Forms.ComboBox();
            this.cmbCodigoCajas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnGenerarBoleta = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbBuscarCaja = new System.Windows.Forms.ComboBox();
            this.lvReporte1 = new System.Windows.Forms.ListView();
            this.btnListarComprasxCaja = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.btnMontoTotalComprasDeCajas = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblCajasMasCompras = new System.Windows.Forms.Label();
            this.btnObtenerCajaMasCompras = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnListarComprasDeCliente = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmbCodigoCliente = new System.Windows.Forms.ComboBox();
            this.lvReporte3 = new System.Windows.Forms.ListView();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lvClienteMinMontoCompra = new System.Windows.Forms.ListView();
            this.btnClienteMinMontoCompra = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvCajas);
            this.groupBox1.Controls.Add(this.btnAgregarCaja);
            this.groupBox1.Controls.Add(this.txtNombreCajero);
            this.groupBox1.Controls.Add(this.txtCodigoCaja);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caja";
            // 
            // lvCajas
            // 
            this.lvCajas.HideSelection = false;
            this.lvCajas.Location = new System.Drawing.Point(11, 174);
            this.lvCajas.Name = "lvCajas";
            this.lvCajas.Size = new System.Drawing.Size(276, 121);
            this.lvCajas.TabIndex = 5;
            this.lvCajas.UseCompatibleStateImageBehavior = false;
            // 
            // btnAgregarCaja
            // 
            this.btnAgregarCaja.Location = new System.Drawing.Point(112, 118);
            this.btnAgregarCaja.Name = "btnAgregarCaja";
            this.btnAgregarCaja.Size = new System.Drawing.Size(75, 35);
            this.btnAgregarCaja.TabIndex = 4;
            this.btnAgregarCaja.Text = "Agregar";
            this.btnAgregarCaja.UseVisualStyleBackColor = true;
            this.btnAgregarCaja.Click += new System.EventHandler(this.btnAgregarCaja_Click);
            // 
            // txtNombreCajero
            // 
            this.txtNombreCajero.Location = new System.Drawing.Point(146, 75);
            this.txtNombreCajero.Name = "txtNombreCajero";
            this.txtNombreCajero.Size = new System.Drawing.Size(128, 22);
            this.txtNombreCajero.TabIndex = 3;
            // 
            // txtCodigoCaja
            // 
            this.txtCodigoCaja.Location = new System.Drawing.Point(146, 33);
            this.txtCodigoCaja.Name = "txtCodigoCaja";
            this.txtCodigoCaja.Size = new System.Drawing.Size(128, 22);
            this.txtCodigoCaja.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Cajero:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código caja:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtFechaCompra);
            this.groupBox2.Controls.Add(this.txtMontoCompra);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lvCompras);
            this.groupBox2.Controls.Add(this.btnAgregarCompra);
            this.groupBox2.Controls.Add(this.txtDniCliente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(354, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 305);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compra";
            // 
            // dtFechaCompra
            // 
            this.dtFechaCompra.Location = new System.Drawing.Point(164, 88);
            this.dtFechaCompra.Name = "dtFechaCompra";
            this.dtFechaCompra.Size = new System.Drawing.Size(131, 22);
            this.dtFechaCompra.TabIndex = 8;
            // 
            // txtMontoCompra
            // 
            this.txtMontoCompra.Location = new System.Drawing.Point(167, 60);
            this.txtMontoCompra.Name = "txtMontoCompra";
            this.txtMontoCompra.Size = new System.Drawing.Size(128, 22);
            this.txtMontoCompra.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Monto:";
            // 
            // lvCompras
            // 
            this.lvCompras.HideSelection = false;
            this.lvCompras.Location = new System.Drawing.Point(11, 174);
            this.lvCompras.Name = "lvCompras";
            this.lvCompras.Size = new System.Drawing.Size(276, 121);
            this.lvCompras.TabIndex = 5;
            this.lvCompras.UseCompatibleStateImageBehavior = false;
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.Location = new System.Drawing.Point(118, 127);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(75, 35);
            this.btnAgregarCompra.TabIndex = 4;
            this.btnAgregarCompra.Text = "Agregar";
            this.btnAgregarCompra.UseVisualStyleBackColor = true;
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnAgregarCompra_Click);
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(167, 30);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(128, 22);
            this.txtDniCliente.TabIndex = 2;
            this.txtDniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniCliente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-9, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "DNI Cliente(Cod Compra):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbCodigoCompra);
            this.groupBox3.Controls.Add(this.cmbCodigoCajas);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.listView2);
            this.groupBox3.Controls.Add(this.btnGenerarBoleta);
            this.groupBox3.Controls.Add(this.lbl);
            this.groupBox3.Location = new System.Drawing.Point(711, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 162);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Boleta";
            // 
            // cmbCodigoCompra
            // 
            this.cmbCodigoCompra.FormattingEnabled = true;
            this.cmbCodigoCompra.Location = new System.Drawing.Point(141, 65);
            this.cmbCodigoCompra.Name = "cmbCodigoCompra";
            this.cmbCodigoCompra.Size = new System.Drawing.Size(121, 24);
            this.cmbCodigoCompra.TabIndex = 8;
            // 
            // cmbCodigoCajas
            // 
            this.cmbCodigoCajas.FormattingEnabled = true;
            this.cmbCodigoCajas.Location = new System.Drawing.Point(141, 35);
            this.cmbCodigoCajas.Name = "cmbCodigoCajas";
            this.cmbCodigoCajas.Size = new System.Drawing.Size(121, 24);
            this.cmbCodigoCajas.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Código Compra:";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(11, 174);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(276, 121);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnGenerarBoleta
            // 
            this.btnGenerarBoleta.Location = new System.Drawing.Point(124, 118);
            this.btnGenerarBoleta.Name = "btnGenerarBoleta";
            this.btnGenerarBoleta.Size = new System.Drawing.Size(75, 35);
            this.btnGenerarBoleta.TabIndex = 4;
            this.btnGenerarBoleta.Text = "Generar";
            this.btnGenerarBoleta.UseVisualStyleBackColor = true;
            this.btnGenerarBoleta.Click += new System.EventHandler(this.btnGenerarBoleta_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(10, 38);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 17);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "CódCaja:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbBuscarCaja);
            this.groupBox4.Controls.Add(this.lvReporte1);
            this.groupBox4.Controls.Add(this.btnListarComprasxCaja);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(27, 362);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 249);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reporte 1";
            // 
            // cmbBuscarCaja
            // 
            this.cmbBuscarCaja.FormattingEnabled = true;
            this.cmbBuscarCaja.Location = new System.Drawing.Point(112, 31);
            this.cmbBuscarCaja.Name = "cmbBuscarCaja";
            this.cmbBuscarCaja.Size = new System.Drawing.Size(163, 24);
            this.cmbBuscarCaja.TabIndex = 6;
            // 
            // lvReporte1
            // 
            this.lvReporte1.HideSelection = false;
            this.lvReporte1.Location = new System.Drawing.Point(13, 120);
            this.lvReporte1.Name = "lvReporte1";
            this.lvReporte1.Size = new System.Drawing.Size(276, 117);
            this.lvReporte1.TabIndex = 5;
            this.lvReporte1.UseCompatibleStateImageBehavior = false;
            // 
            // btnListarComprasxCaja
            // 
            this.btnListarComprasxCaja.Location = new System.Drawing.Point(112, 79);
            this.btnListarComprasxCaja.Name = "btnListarComprasxCaja";
            this.btnListarComprasxCaja.Size = new System.Drawing.Size(102, 35);
            this.btnListarComprasxCaja.TabIndex = 4;
            this.btnListarComprasxCaja.Text = "Ver Reporte";
            this.btnListarComprasxCaja.UseVisualStyleBackColor = true;
            this.btnListarComprasxCaja.Click += new System.EventHandler(this.btnListarComprasxCaja_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Caja:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblMontoTotal);
            this.groupBox5.Controls.Add(this.btnMontoTotalComprasDeCajas);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(354, 345);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(336, 131);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reporte 2";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(176, 80);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(17, 17);
            this.lblMontoTotal.TabIndex = 5;
            this.lblMontoTotal.Text = "X";
            // 
            // btnMontoTotalComprasDeCajas
            // 
            this.btnMontoTotalComprasDeCajas.Location = new System.Drawing.Point(130, 29);
            this.btnMontoTotalComprasDeCajas.Name = "btnMontoTotalComprasDeCajas";
            this.btnMontoTotalComprasDeCajas.Size = new System.Drawing.Size(102, 35);
            this.btnMontoTotalComprasDeCajas.TabIndex = 4;
            this.btnMontoTotalComprasDeCajas.Text = "Obtener";
            this.btnMontoTotalComprasDeCajas.UseVisualStyleBackColor = true;
            this.btnMontoTotalComprasDeCajas.Click += new System.EventHandler(this.btnMontoTotalComprasDeCajas_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblCajasMasCompras);
            this.groupBox6.Controls.Add(this.btnObtenerCajaMasCompras);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(354, 488);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(336, 123);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Reporte 3";
            // 
            // lblCajasMasCompras
            // 
            this.lblCajasMasCompras.AutoSize = true;
            this.lblCajasMasCompras.Location = new System.Drawing.Point(176, 77);
            this.lblCajasMasCompras.Name = "lblCajasMasCompras";
            this.lblCajasMasCompras.Size = new System.Drawing.Size(17, 17);
            this.lblCajasMasCompras.TabIndex = 6;
            this.lblCajasMasCompras.Text = "X";
            // 
            // btnObtenerCajaMasCompras
            // 
            this.btnObtenerCajaMasCompras.Location = new System.Drawing.Point(130, 20);
            this.btnObtenerCajaMasCompras.Name = "btnObtenerCajaMasCompras";
            this.btnObtenerCajaMasCompras.Size = new System.Drawing.Size(102, 35);
            this.btnObtenerCajaMasCompras.TabIndex = 4;
            this.btnObtenerCajaMasCompras.Text = "Obtener";
            this.btnObtenerCajaMasCompras.UseVisualStyleBackColor = true;
            this.btnObtenerCajaMasCompras.Click += new System.EventHandler(this.btnObtenerCajaMasCompras_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 17);
            this.label11.TabIndex = 0;
            // 
            // btnListarComprasDeCliente
            // 
            this.btnListarComprasDeCliente.Location = new System.Drawing.Point(222, 29);
            this.btnListarComprasDeCliente.Name = "btnListarComprasDeCliente";
            this.btnListarComprasDeCliente.Size = new System.Drawing.Size(102, 35);
            this.btnListarComprasDeCliente.TabIndex = 4;
            this.btnListarComprasDeCliente.Text = "Obtener";
            this.btnListarComprasDeCliente.UseVisualStyleBackColor = true;
            this.btnListarComprasDeCliente.Click += new System.EventHandler(this.btnListarComprasDeCliente_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbCodigoCliente);
            this.groupBox7.Controls.Add(this.lvReporte3);
            this.groupBox7.Controls.Add(this.btnListarComprasDeCliente);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Location = new System.Drawing.Point(711, 186);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(349, 212);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Reporte 3";
            // 
            // cmbCodigoCliente
            // 
            this.cmbCodigoCliente.FormattingEnabled = true;
            this.cmbCodigoCliente.Location = new System.Drawing.Point(78, 35);
            this.cmbCodigoCliente.Name = "cmbCodigoCliente";
            this.cmbCodigoCliente.Size = new System.Drawing.Size(121, 24);
            this.cmbCodigoCliente.TabIndex = 6;
            // 
            // lvReporte3
            // 
            this.lvReporte3.HideSelection = false;
            this.lvReporte3.Location = new System.Drawing.Point(26, 78);
            this.lvReporte3.Name = "lvReporte3";
            this.lvReporte3.Size = new System.Drawing.Size(298, 117);
            this.lvReporte3.TabIndex = 5;
            this.lvReporte3.UseCompatibleStateImageBehavior = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Cliente:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lvClienteMinMontoCompra);
            this.groupBox8.Controls.Add(this.btnClienteMinMontoCompra);
            this.groupBox8.Controls.Add(this.textBox9);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Location = new System.Drawing.Point(711, 406);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(349, 205);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Reporte 4";
            // 
            // lvClienteMinMontoCompra
            // 
            this.lvClienteMinMontoCompra.HideSelection = false;
            this.lvClienteMinMontoCompra.Location = new System.Drawing.Point(14, 78);
            this.lvClienteMinMontoCompra.Name = "lvClienteMinMontoCompra";
            this.lvClienteMinMontoCompra.Size = new System.Drawing.Size(298, 117);
            this.lvClienteMinMontoCompra.TabIndex = 5;
            this.lvClienteMinMontoCompra.UseCompatibleStateImageBehavior = false;
            // 
            // btnClienteMinMontoCompra
            // 
            this.btnClienteMinMontoCompra.Location = new System.Drawing.Point(210, 29);
            this.btnClienteMinMontoCompra.Name = "btnClienteMinMontoCompra";
            this.btnClienteMinMontoCompra.Size = new System.Drawing.Size(102, 35);
            this.btnClienteMinMontoCompra.TabIndex = 4;
            this.btnClienteMinMontoCompra.Text = "Obtener";
            this.btnClienteMinMontoCompra.UseVisualStyleBackColor = true;
            this.btnClienteMinMontoCompra.Click += new System.EventHandler(this.btnClienteMinMontoCompra_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(71, 35);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(128, 22);
            this.textBox9.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Cliente:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 649);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarCaja;
        private System.Windows.Forms.TextBox txtNombreCajero;
        private System.Windows.Forms.TextBox txtCodigoCaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvCajas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvCompras;
        private System.Windows.Forms.Button btnAgregarCompra;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnGenerarBoleta;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvReporte1;
        private System.Windows.Forms.Button btnListarComprasxCaja;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnMontoTotalComprasDeCajas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblCajasMasCompras;
        private System.Windows.Forms.Button btnListarComprasDeCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListView lvReporte3;
        private System.Windows.Forms.Button btnObtenerCajaMasCompras;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ListView lvClienteMinMontoCompra;
        private System.Windows.Forms.Button btnClienteMinMontoCompra;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtFechaCompra;
        private System.Windows.Forms.ComboBox cmbCodigoCompra;
        private System.Windows.Forms.ComboBox cmbCodigoCajas;
        private System.Windows.Forms.ComboBox cmbBuscarCaja;
        private System.Windows.Forms.ComboBox cmbCodigoCliente;
    }
}

