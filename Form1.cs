using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

namespace Ejercicio02_Cajas
{
    public partial class Form1 : Form
    {
        private List<CCaja> listCajas;
        private List<CCompra> listCompras;
        private List<ComprasxCaja> listComprasxCaja;
        public Form1()
        {
            InitializeComponent();
            listCajas = new List<CCaja>();
            listCompras = new List<CCompra>();
            listComprasxCaja = new List<ComprasxCaja>();

            lvCajas.View = View.Details;
            lvCajas.Columns.Add("Codigo");
            lvCajas.Columns.Add("Cajero");

            lvCompras.View = View.Details;
            lvCompras.Columns.Add("DNI Cliente");
            lvCompras.Columns.Add("Monto");
            lvCompras.Columns.Add("Fecha");
        }

        private void btnAgregarCaja_Click(object sender, EventArgs e)
        {
            String codigoCaja = txtCodigoCaja.Text.Trim();
            String nombreCajero = txtNombreCajero.Text.Trim();
            ListViewItem lvaux = new ListViewItem();

            if (!listCajas.Exists(X => X.CodigoCaja == codigoCaja))
            {
                listCajas.Add(new CCaja(codigoCaja, nombreCajero));
                txtCodigoCaja.Clear();
                txtNombreCajero.Clear();

                lvaux.Text = codigoCaja;
                lvaux.SubItems.Add(nombreCajero);
                lvCajas.Items.Add(lvaux);

                cmbCodigoCajas.Items.Add(codigoCaja);
                cmbBuscarCaja.Items.Add(codigoCaja);
            }
            else
            {
                MessageBox.Show("Este código ya se encuentra registrado");
            }
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            int dniCliente = Convert.ToInt32(txtDniCliente.Text.Trim());
            double montoCompra = Convert.ToDouble(txtMontoCompra.Text.Trim());
            DateTime fechaCompra = dtFechaCompra.Value.Date;

            ListViewItem lvaux = new ListViewItem();

            if (!listCompras.Exists(X => X.DniCliente == dniCliente))
            {
                listCompras.Add(new CCompra(dniCliente, montoCompra, fechaCompra));
                txtDniCliente.Clear();
                txtMontoCompra.Clear();

                lvaux.Text = Convert.ToString(dniCliente);
                lvaux.SubItems.Add(Convert.ToString(montoCompra));
                lvaux.SubItems.Add(Convert.ToString(fechaCompra));
                lvCompras.Items.Add(lvaux);

                cmbCodigoCompra.Items.Add(dniCliente);
                cmbCodigoCliente.Items.Add(dniCliente);
            }
            else
            {
                MessageBox.Show("Este código de compra ya existe");
            }
        }

        private void btnGenerarBoleta_Click(object sender, EventArgs e)
        {
            String codigoCaja = cmbCodigoCajas.Text;
            String codigoCompra = cmbCodigoCompra.Text;

            if (cmbCodigoCajas.SelectedIndex != -1 && cmbCodigoCompra.SelectedIndex != -1)
            {
                ComprasxCaja compraxcaja = new ComprasxCaja();
                compraxcaja.CodigoCaja = codigoCaja;
                compraxcaja.CodigoCliente = codigoCompra;

                listComprasxCaja.Add(compraxcaja);

                cmbCodigoCajas.SelectedIndex = -1;
                cmbCodigoCompra.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Seleccione una opción");
            }
        }

        //LISTAR COMPRAS DE UNA CAJA
        private void btnListarComprasxCaja_Click(object sender, EventArgs e)
        {
            String cajaBuscar = cmbBuscarCaja.Text.Trim();

            if (cmbBuscarCaja.SelectedIndex != -1)
            {
                //buscar la caja
                List<ComprasxCaja> listBusqueda = listComprasxCaja.FindAll(X => X.CodigoCaja == cajaBuscar);
                //la listBusqueda será igual al valor seleccionado en el cmbCaja

                lvReporte1.Items.Clear();
                lvReporte1.View = View.Details;
                lvReporte1.Columns.Add("Cod.Cliente");
                lvReporte1.Columns.Add("Monto");
                lvReporte1.Columns.Add("Fecha");

                //busca las compras en tdas las listas de compras
                foreach (var item in listCompras)
                {
                    if (listBusqueda.Exists(X => X.CodigoCliente == item.DniCliente.ToString()))
                    {
                        ListViewItem lvaux = new ListViewItem();
                        lvaux.Text = item.DniCliente.ToString();
                        lvaux.SubItems.Add(item.MontoCompra.ToString());
                        lvaux.SubItems.Add(item.FechaCompra.ToString());
                        lvReporte1.Items.Add(lvaux);
                    }
                    else
                    {
                        MessageBox.Show("No existen compras en este Caja");
                    }
                }

            }
            else
            {
                MessageBox.Show("Seleccione una caja, por favor");
            }

        }

        //LISTAR LAS CAJAS DONDE UN DETERMINADO CLIENTE HAYA REALIZADO UNA COMPRA
        private void btnListarComprasDeCliente_Click(object sender, EventArgs e)
        {
            lvReporte3.Clear();
            lvReporte3.View = View.Details;
            lvReporte3.Columns.Add("Codigo");
            lvReporte3.Columns.Add("Cajero");

            String codigoCliente = cmbCodigoCliente.Text;
            List<ComprasxCaja> listbusqueda = listComprasxCaja.FindAll(X => X.CodigoCliente == codigoCliente);

            foreach (var item in listCajas)
            {
                if (listbusqueda.Exists(X => X.CodigoCaja == item.CodigoCaja.ToString()))
                {
                    ListViewItem lvaux = new ListViewItem();
                    lvaux.Text = item.CodigoCaja;
                    lvaux.SubItems.Add(item.NombreCajero);
                    lvReporte3.Items.Add(lvaux);
                }
            }
        }

        //OBTENER EL O LOS CLIENTES CON MENOR MONTO DE COMPRA
        private void btnClienteMinMontoCompra_Click(object sender, EventArgs e)
        {
            lvClienteMinMontoCompra.Clear();
            lvClienteMinMontoCompra.View = View.Details;
            lvClienteMinMontoCompra.Columns.Add("CodigoCliente");
            lvClienteMinMontoCompra.Columns.Add("Monto");
            lvClienteMinMontoCompra.Columns.Add("Fecha");

            List<CCompra> listbusqueda = listCompras.FindAll(X => X.MontoCompra == listCompras.Min(Y => Y.MontoCompra));

            foreach (var item in listCompras)
            {
                if (listbusqueda.Exists(X => X.DniCliente == item.DniCliente))
                {
                    ListViewItem lvaux = new ListViewItem();
                    lvaux.Text = Convert.ToString(item.DniCliente);
                    lvaux.SubItems.Add(Convert.ToString(item.MontoCompra));
                    lvaux.SubItems.Add(Convert.ToString(item.FechaCompra));
                    lvClienteMinMontoCompra.Items.Add(lvaux);
                }
            }

        }

        //OBTENER EL MONTO TOTAL DE COMPRAS DE TODAS LAS CAJAS
        private void btnMontoTotalComprasDeCajas_Click(object sender, EventArgs e)
        {
            double total = listCompras.Sum(Y => Y.MontoCompra);
            lblMontoTotal.Text = total.ToString();
        }


        //OBTENER LA CAJA CON MÁS COMPRAS - USO DEL HASHTABLE
        private void btnObtenerCajaMasCompras_Click(object sender, EventArgs e)
        {
            int[] array = new int[listComprasxCaja.Count];
            int i = 0;

            foreach (var item in listComprasxCaja)
            {
                array[i] = Convert.ToInt32(item.CodigoCaja);
                i++;

            }
            lblCajasMasCompras.Text = "Respuesta " + masCompras(array);
        }
        String masCompras(int[] array)
        {
            //hashtable
            int mascomun = array[0];
            int ocurrencias = 0;
            Hashtable has = new Hashtable();
            int tempoOcurrencias = 0;

            foreach (var num in array)
            {
                if (!has.ContainsKey(num)) //si no contiene el item 1 (1:codigo de caja)
                {
                    has.Add(num, 1);// agrega el nro de caja una vez (1:una vez)
                }
                else
                {
                    tempoOcurrencias = (int)has[num]; // (int): casteo
                    tempoOcurrencias++;
                    has.Remove(num); // limpiar
                    has.Add(num, tempoOcurrencias); //agrega de nuevo

                    if (ocurrencias < tempoOcurrencias)
                    {
                        ocurrencias = tempoOcurrencias;
                        mascomun = num;
                    }
                }
            }

            //
            String valores = "";
            if (ocurrencias == 0) ocurrencias++;

            foreach (DictionaryEntry entry in has)
            {
                if (Convert.ToInt32(entry.Value) == ocurrencias) //value:cant de veces q ocurre
                {
                    valores = valores + ", " + entry.Key;
                }
            }

            valores = valores.Replace(",", " "); //"1 2 1
            valores = valores.Trim(); //"2 1"
            valores = valores.Replace(" ", ","); //"2,1"
            //return valores.ToString();
            return mascomun.ToString();
        }

        //VALIDAR QUE SOLO SE INGRESEN NROS
        private void txtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}