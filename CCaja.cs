using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_Cajas
{
    public class CCaja
    {
        string codigoCaja;
        string nombreCajero;

        public string CodigoCaja { get => codigoCaja; set => codigoCaja = value; }
        public string NombreCajero { get => nombreCajero; set => nombreCajero = value; }
        
        public CCaja(string codigoCaja, string nombreCajero)
        {
            this.codigoCaja = codigoCaja;
            this.nombreCajero = nombreCajero;
        }
    }

}
