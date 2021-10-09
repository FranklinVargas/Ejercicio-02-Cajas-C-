using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_Cajas
{
    public class CCompra
    {
        int dniCliente;
        double montoCompra;
        DateTime fechaCompra;

        public int DniCliente { get => dniCliente; set => dniCliente = value; }
        public double MontoCompra { get => montoCompra; set => montoCompra = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }

        public CCompra(int dniCliente, double montoCompra, DateTime fechaCompra)
        {
            this.dniCliente = dniCliente;
            this.montoCompra = montoCompra;
            this.fechaCompra = fechaCompra;

        }
    }
}
